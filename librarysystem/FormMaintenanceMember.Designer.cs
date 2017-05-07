namespace SA43Team4B
{
    partial class FormMaintenanceMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaintenanceMember));
            this.MemberTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.btnAddNewMember = new System.Windows.Forms.Button();
            this.cboMemberType = new System.Windows.Forms.ComboBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtCardStatus = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCardStatus = new System.Windows.Forms.Label();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMClear = new System.Windows.Forms.Button();
            this.cboMGender = new System.Windows.Forms.ComboBox();
            this.cboMMemberID = new System.Windows.Forms.ComboBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMDepartment = new System.Windows.Forms.TextBox();
            this.txtMCardStatus = new System.Windows.Forms.TextBox();
            this.txtMPhone = new System.Windows.Forms.TextBox();
            this.txtMAddress = new System.Windows.Forms.TextBox();
            this.txtMEmail = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboMMemberType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MemberTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberTabControl
            // 
            this.MemberTabControl.Controls.Add(this.tabPage1);
            this.MemberTabControl.Controls.Add(this.tabPage2);
            this.MemberTabControl.Location = new System.Drawing.Point(11, 73);
            this.MemberTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.MemberTabControl.Name = "MemberTabControl";
            this.MemberTabControl.SelectedIndex = 0;
            this.MemberTabControl.Size = new System.Drawing.Size(603, 278);
            this.MemberTabControl.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.cboGender);
            this.tabPage1.Controls.Add(this.btnAddNewMember);
            this.tabPage1.Controls.Add(this.cboMemberType);
            this.tabPage1.Controls.Add(this.txtDepartment);
            this.tabPage1.Controls.Add(this.txtCardStatus);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtMemberID);
            this.tabPage1.Controls.Add(this.lblAddress);
            this.tabPage1.Controls.Add(this.lblDepartment);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.lblPhone);
            this.tabPage1.Controls.Add(this.lblGender);
            this.tabPage1.Controls.Add(this.lblCardStatus);
            this.tabPage1.Controls.Add(this.lblMemberType);
            this.tabPage1.Controls.Add(this.lblMemberName);
            this.tabPage1.Controls.Add(this.lblMemberID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(595, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Member";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(320, 200);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 24);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Unknow"});
            this.cboGender.Location = new System.Drawing.Point(125, 160);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(129, 21);
            this.cboGender.TabIndex = 13;
            // 
            // btnAddNewMember
            // 
            this.btnAddNewMember.Location = new System.Drawing.Point(410, 200);
            this.btnAddNewMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewMember.Name = "btnAddNewMember";
            this.btnAddNewMember.Size = new System.Drawing.Size(85, 24);
            this.btnAddNewMember.TabIndex = 21;
            this.btnAddNewMember.Text = "Add Member";
            this.btnAddNewMember.UseVisualStyleBackColor = true;
            this.btnAddNewMember.Click += new System.EventHandler(this.btnAddNewMember_Click);
            // 
            // cboMemberType
            // 
            this.cboMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberType.FormattingEnabled = true;
            this.cboMemberType.Location = new System.Drawing.Point(125, 100);
            this.cboMemberType.Margin = new System.Windows.Forms.Padding(2);
            this.cboMemberType.Name = "cboMemberType";
            this.cboMemberType.Size = new System.Drawing.Size(129, 21);
            this.cboMemberType.TabIndex = 11;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(365, 100);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(129, 20);
            this.txtDepartment.TabIndex = 16;
            // 
            // txtCardStatus
            // 
            this.txtCardStatus.Location = new System.Drawing.Point(125, 130);
            this.txtCardStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtCardStatus.Name = "txtCardStatus";
            this.txtCardStatus.Size = new System.Drawing.Size(129, 20);
            this.txtCardStatus.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(365, 40);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(129, 20);
            this.txtPhone.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(365, 130);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(129, 56);
            this.txtAddress.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(365, 70);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 70);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(125, 40);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(129, 20);
            this.txtMemberID.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(290, 135);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(290, 105);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 7;
            this.lblDepartment.Text = "Department:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(290, 75);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(290, 45);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(40, 165);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            // 
            // lblCardStatus
            // 
            this.lblCardStatus.AutoSize = true;
            this.lblCardStatus.Location = new System.Drawing.Point(40, 135);
            this.lblCardStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardStatus.Name = "lblCardStatus";
            this.lblCardStatus.Size = new System.Drawing.Size(65, 13);
            this.lblCardStatus.TabIndex = 3;
            this.lblCardStatus.Text = "Card Status:";
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Location = new System.Drawing.Point(40, 105);
            this.lblMemberType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(75, 13);
            this.lblMemberType.TabIndex = 2;
            this.lblMemberType.Text = "Member Type:";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(40, 75);
            this.lblMemberName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(38, 13);
            this.lblMemberName.TabIndex = 1;
            this.lblMemberName.Text = "Name:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(40, 45);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(62, 13);
            this.lblMemberID.TabIndex = 0;
            this.lblMemberID.Text = "Member ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnMClear);
            this.tabPage2.Controls.Add(this.cboMGender);
            this.tabPage2.Controls.Add(this.cboMMemberID);
            this.tabPage2.Controls.Add(this.btnFirst);
            this.tabPage2.Controls.Add(this.btnLast);
            this.tabPage2.Controls.Add(this.btnNext);
            this.tabPage2.Controls.Add(this.btnPrevious);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.txtMDepartment);
            this.tabPage2.Controls.Add(this.txtMCardStatus);
            this.tabPage2.Controls.Add(this.txtMPhone);
            this.tabPage2.Controls.Add(this.txtMAddress);
            this.tabPage2.Controls.Add(this.txtMEmail);
            this.tabPage2.Controls.Add(this.txtMName);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.cboMMemberType);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(595, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modify Member";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnMClear
            // 
            this.btnMClear.Location = new System.Drawing.Point(140, 210);
            this.btnMClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnMClear.Name = "btnMClear";
            this.btnMClear.Size = new System.Drawing.Size(85, 24);
            this.btnMClear.TabIndex = 73;
            this.btnMClear.Text = "Clear";
            this.btnMClear.UseVisualStyleBackColor = true;
            this.btnMClear.Click += new System.EventHandler(this.btnMClear_Click);
            // 
            // cboMGender
            // 
            this.cboMGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMGender.FormattingEnabled = true;
            this.cboMGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Unknow"});
            this.cboMGender.Location = new System.Drawing.Point(125, 160);
            this.cboMGender.Name = "cboMGender";
            this.cboMGender.Size = new System.Drawing.Size(129, 21);
            this.cboMGender.TabIndex = 55;
            // 
            // cboMMemberID
            // 
            this.cboMMemberID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMMemberID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMMemberID.DropDownHeight = 80;
            this.cboMMemberID.FormattingEnabled = true;
            this.cboMMemberID.IntegralHeight = false;
            this.cboMMemberID.Location = new System.Drawing.Point(125, 40);
            this.cboMMemberID.Name = "cboMMemberID";
            this.cboMMemberID.Size = new System.Drawing.Size(129, 21);
            this.cboMMemberID.TabIndex = 51;
            this.cboMMemberID.TextChanged += new System.EventHandler(this.cboMMemberID_TextChanged);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(50, 210);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(40, 24);
            this.btnFirst.TabIndex = 71;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(455, 210);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(40, 24);
            this.btnLast.TabIndex = 77;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(410, 210);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 24);
            this.btnNext.TabIndex = 76;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(95, 210);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(40, 24);
            this.btnPrevious.TabIndex = 72;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(320, 210);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 24);
            this.btnDelete.TabIndex = 75;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtMDepartment
            // 
            this.txtMDepartment.Location = new System.Drawing.Point(365, 100);
            this.txtMDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.txtMDepartment.Name = "txtMDepartment";
            this.txtMDepartment.Size = new System.Drawing.Size(129, 20);
            this.txtMDepartment.TabIndex = 58;
            // 
            // txtMCardStatus
            // 
            this.txtMCardStatus.Location = new System.Drawing.Point(125, 130);
            this.txtMCardStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtMCardStatus.Name = "txtMCardStatus";
            this.txtMCardStatus.Size = new System.Drawing.Size(129, 20);
            this.txtMCardStatus.TabIndex = 54;
            // 
            // txtMPhone
            // 
            this.txtMPhone.Location = new System.Drawing.Point(365, 40);
            this.txtMPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtMPhone.Name = "txtMPhone";
            this.txtMPhone.Size = new System.Drawing.Size(129, 20);
            this.txtMPhone.TabIndex = 56;
            // 
            // txtMAddress
            // 
            this.txtMAddress.Location = new System.Drawing.Point(365, 130);
            this.txtMAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtMAddress.Multiline = true;
            this.txtMAddress.Name = "txtMAddress";
            this.txtMAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMAddress.Size = new System.Drawing.Size(129, 56);
            this.txtMAddress.TabIndex = 59;
            // 
            // txtMEmail
            // 
            this.txtMEmail.Location = new System.Drawing.Point(365, 70);
            this.txtMEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMEmail.Name = "txtMEmail";
            this.txtMEmail.Size = new System.Drawing.Size(129, 20);
            this.txtMEmail.TabIndex = 57;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(125, 70);
            this.txtMName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(129, 20);
            this.txtMName.TabIndex = 52;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(230, 210);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 24);
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboMMemberType
            // 
            this.cboMMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMMemberType.FormattingEnabled = true;
            this.cboMMemberType.Location = new System.Drawing.Point(125, 100);
            this.cboMMemberType.Margin = new System.Windows.Forms.Padding(2);
            this.cboMMemberType.Name = "cboMMemberType";
            this.cboMMemberType.Size = new System.Drawing.Size(129, 21);
            this.cboMMemberType.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Department:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Card Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Member Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Member ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 56);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // FormMaintenanceMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.MemberTabControl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMaintenanceMember";
            this.Text = "Member Maintenance";
            this.Load += new System.EventHandler(this.MemberMaintenance_Load);
            this.MemberTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MemberTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAddNewMember;
        private System.Windows.Forms.ComboBox cboMemberType;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtCardStatus;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCardStatus;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtMDepartment;
        private System.Windows.Forms.TextBox txtMCardStatus;
        private System.Windows.Forms.TextBox txtMPhone;
        private System.Windows.Forms.TextBox txtMAddress;
        private System.Windows.Forms.TextBox txtMEmail;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboMMemberType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboMMemberID;
        private System.Windows.Forms.ComboBox cboMGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Button btnMClear;
        private System.Windows.Forms.Button btnClear;
    }
}