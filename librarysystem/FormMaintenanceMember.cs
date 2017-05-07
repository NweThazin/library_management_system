using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA43Team4B
{
    public partial class FormMaintenanceMember : Form
    {
        // <attributes>
        LibrarySystemEntities context = new LibrarySystemEntities(); 
        List<Member> mlst;
        int pos = 0;    // current index shown
        int ind = 0;    // total rows entity has
        // </attributes>

        // <Load Entity>
        public void LoadEntity()
        {
            //context = new LibrarySystemEntities();
            //context.
            mlst = context.Members.ToList();
            pos = 0;
            ind = context.Members.Count()-1;    // 0 ~ Count-1
            InitializeComboBox();
            UpdateText(pos);
        }
        // </Load Entity>
        
        // <UI methods>
        public FormMaintenanceMember()
        {
            InitializeComponent();
        }
        public FormMaintenanceMember(int page)
        {
            InitializeComponent();
            if (page == 1)
                MemberTabControl.SelectedTab = tabPage1;
            else
                MemberTabControl.SelectedTab = tabPage2;
        }
        private void MemberMaintenance_Load(object sender, EventArgs e)  // load the form
        {
            LoadEntity();
            InitializeComboBox();
            cboGender.Items.Add("");
            cboMGender.Items.Add("");
            UpdateText(pos);
        }

        private void InitializeComboBox()  // fill in all ComboBoxes
        {
            // fill MemberID list in Modify tab, with AutoComplete
            AutoCompleteStringCollection AutoCollection = new AutoCompleteStringCollection();
            cboMMemberID.Items.Clear();
            cboMemberType.Items.Clear();
            cboMMemberType.Items.Clear();
            foreach (Member m in mlst)
            {
                cboMMemberID.Items.Add(m.MemberID.ToString());
                AutoCollection.Add(m.MemberID.ToString());
            }
            cboMMemberID.AutoCompleteCustomSource = AutoCollection;
            // fill MemberType list (Add/Modify)
            List<MemberCategory> mcl;
            mcl = context.MemberCategories.ToList();
            foreach (MemberCategory mc in mcl)
            {
                cboMemberType.Items.Add(mc.MemberType.ToString());
                cboMMemberType.Items.Add(mc.MemberType.ToString());
            }
            cboMemberType.Items.Add("");
            cboMMemberType.Items.Add("");
        }

        private void cboMMemberID_TextChanged(object sender, EventArgs e)  // when select a member, find the index and update screen 
        {
            int i = cboMMemberID.Items.IndexOf(cboMMemberID.Text);
            if (i >= 0)
            {
                pos = i;
                UpdateText(i);
            }
        }

        private void UpdateText(int i)  // act as broker from Entity to UI
        {
            try
            {
                txtMName.Text = ToStr(mlst[i].MemberName);
                txtMCardStatus.Text = ToStr(mlst[i].LibraryCardStatus);
                txtMPhone.Text = ToStr(mlst[i].MemberPhone);
                txtMEmail.Text = ToStr(mlst[i].MemberEmail);
                txtMDepartment.Text = ToStr(mlst[i].MemberDepartment);
                txtMAddress.Text = ToStr(mlst[i].MemberAddress);
                cboMMemberID.Text = ToStr(mlst[i].MemberID);
                cboMGender.Text = ToStr(mlst[i].MemberGender);
                cboMMemberType.Text = ToStr(mlst[i].MemberType);
            }
            catch (Exception except)
            {
                MessageBox.Show(except.ToString());
            }
        }
        // <UI Event Handler>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            UpdateText(pos);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0) pos--;
            UpdateText(pos);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pos < ind) pos++;
            UpdateText(pos);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pos = ind;
            UpdateText(pos);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtCardStatus.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtDepartment.Text = "";
            txtAddress.Text = "";
            txtMemberID.Text = "";
            cboGender.Text = "";
            cboMemberType.Text = "";
        }
        
        private void btnMClear_Click(object sender, EventArgs e)
        {
            txtMName.Text = "";
            txtMCardStatus.Text = "";
            txtMPhone.Text = "";
            txtMEmail.Text = "";
            txtMDepartment.Text = "";
            txtMAddress.Text = "";
            cboMMemberID.Text = "";
            cboMGender.Text = "";
            cboMMemberType.Text = "";
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            Member textmb = new Member();
            textmb.MemberName = txtName.Text;
            textmb.LibraryCardStatus = txtCardStatus.Text;
            textmb.MemberPhone = txtPhone.Text;
            textmb.MemberEmail = txtEmail.Text;
            textmb.MemberDepartment = txtDepartment.Text;
            textmb.MemberAddress = txtAddress.Text;
            textmb.MemberID = txtMemberID.Text;
            textmb.MemberGender = cboGender.Text;
            textmb.MemberType = cboMemberType.Text;
            MaintainControlClass mcCtrl = new MaintainControlClass(this);
            string strmsg = mcCtrl.MemberAdd(textmb, context);

            if (MessageBox.Show(strmsg, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                if (strmsg == "MemberID exists. Do you want to modify it?")
                {
                    txtMName.Text = txtName.Text;
                    txtMCardStatus.Text = txtCardStatus.Text;
                    txtMPhone.Text = txtPhone.Text;
                    txtMEmail.Text = txtEmail.Text;
                    txtMDepartment.Text = txtDepartment.Text;
                    txtMDepartment.Text = txtDepartment.Text;
                    txtMAddress.Text = txtAddress.Text;
                    cboMMemberID.Text = txtMemberID.Text;
                    cboMGender.Text = cboGender.Text;
                    cboMMemberType.Text = cboMemberType.Text;

                    MemberTabControl.SelectedTab = tabPage2;
                }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Member textmb = new Member();
            textmb.MemberName = txtMName.Text;
            textmb.LibraryCardStatus = txtMCardStatus.Text;
            textmb.MemberPhone = txtMPhone.Text;
            textmb.MemberEmail = txtMEmail.Text;
            textmb.MemberDepartment = txtMDepartment.Text;
            textmb.MemberAddress = txtMAddress.Text;
            textmb.MemberID = cboMMemberID.Text;
            textmb.MemberGender = cboMGender.Text;
            textmb.MemberType = cboMMemberType.Text;

            MaintainControlClass mcCtrl = new MaintainControlClass(this);
            string strmsg =mcCtrl.MemberUpdate(textmb, context);
            if (MessageBox.Show(strmsg, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                if (strmsg == "MemberID is not exist. Do you want to create one")
                {
                    txtName.Text = txtMName.Text;
                    txtCardStatus.Text = txtMCardStatus.Text;
                    txtPhone.Text = txtMPhone.Text;
                    txtEmail.Text = txtMEmail.Text;
                    txtDepartment.Text = txtMDepartment.Text;
                    txtDepartment.Text = txtMDepartment.Text;
                    txtAddress.Text = txtMAddress.Text;
                    txtMemberID.Text = cboMMemberID.Text;
                    cboGender.Text = cboMGender.Text;
                    cboMemberType.Text = cboMMemberType.Text;
                    
                    MemberTabControl.SelectedTab = tabPage1;
                }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Member textmb = new Member();
            textmb.MemberID = cboMMemberID.Text;
            if (MessageBox.Show("You really want to delete it?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            MaintainControlClass mcCtrl = new MaintainControlClass(this);
            if (!mcCtrl.DeleteCheck(textmb, context))   //not null
            {
                if (MessageBox.Show("This MemberID has Issue Records, You really want to delete it?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            string strmsg = mcCtrl.MemberDelete(textmb, context);
            MessageBox.Show(strmsg);
        }

        // </UI Event Handler>
        // </UI methods>
        public string ToStr(object obj)  // ToString in case of null
        {
            if (obj == null) return "";
            return obj.ToString();
        }

    }
}
