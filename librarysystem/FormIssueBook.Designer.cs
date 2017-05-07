namespace SA43Team4B
{
    partial class FormIssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIssueBook));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupIssueBook = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtMemberType = new System.Windows.Forms.TextBox();
            this.lblMemberCategory = new System.Windows.Forms.Label();
            this.btnNextOne = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBookNumber = new System.Windows.Forms.TextBox();
            this.txtIssueID = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblStaffNumber = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBookNumber = new System.Windows.Forms.Label();
            this.lblIssueNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupIssueBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 291);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(813, 202);
            this.dataGridView1.TabIndex = 19;
            // 
            // groupIssueBook
            // 
            this.groupIssueBook.Controls.Add(this.btnPrint);
            this.groupIssueBook.Controls.Add(this.txtMemberType);
            this.groupIssueBook.Controls.Add(this.lblMemberCategory);
            this.groupIssueBook.Controls.Add(this.btnNextOne);
            this.groupIssueBook.Controls.Add(this.btnCancel);
            this.groupIssueBook.Controls.Add(this.btnConfirm);
            this.groupIssueBook.Controls.Add(this.dtpDueDate);
            this.groupIssueBook.Controls.Add(this.dtpIssueDate);
            this.groupIssueBook.Controls.Add(this.txtRemark);
            this.groupIssueBook.Controls.Add(this.txtEmployeeID);
            this.groupIssueBook.Controls.Add(this.txtMemberID);
            this.groupIssueBook.Controls.Add(this.txtCategory);
            this.groupIssueBook.Controls.Add(this.txtTitle);
            this.groupIssueBook.Controls.Add(this.txtBookNumber);
            this.groupIssueBook.Controls.Add(this.txtIssueID);
            this.groupIssueBook.Controls.Add(this.lblCategory);
            this.groupIssueBook.Controls.Add(this.lblDueDate);
            this.groupIssueBook.Controls.Add(this.lblIssueDate);
            this.groupIssueBook.Controls.Add(this.lblRemark);
            this.groupIssueBook.Controls.Add(this.lblStaffNumber);
            this.groupIssueBook.Controls.Add(this.lblMemberID);
            this.groupIssueBook.Controls.Add(this.lblTitle);
            this.groupIssueBook.Controls.Add(this.lblBookNumber);
            this.groupIssueBook.Controls.Add(this.lblIssueNumber);
            this.groupIssueBook.Location = new System.Drawing.Point(12, 78);
            this.groupIssueBook.Name = "groupIssueBook";
            this.groupIssueBook.Size = new System.Drawing.Size(812, 234);
            this.groupIssueBook.TabIndex = 18;
            this.groupIssueBook.TabStop = false;
            this.groupIssueBook.Text = "Issue Book";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(644, 181);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(69, 26);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtMemberType
            // 
            this.txtMemberType.Location = new System.Drawing.Point(602, 61);
            this.txtMemberType.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberType.Name = "txtMemberType";
            this.txtMemberType.ReadOnly = true;
            this.txtMemberType.Size = new System.Drawing.Size(94, 20);
            this.txtMemberType.TabIndex = 126;
            this.txtMemberType.TabStop = false;
            // 
            // lblMemberCategory
            // 
            this.lblMemberCategory.AutoSize = true;
            this.lblMemberCategory.Location = new System.Drawing.Point(508, 64);
            this.lblMemberCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberCategory.Name = "lblMemberCategory";
            this.lblMemberCategory.Size = new System.Drawing.Size(35, 13);
            this.lblMemberCategory.TabIndex = 23;
            this.lblMemberCategory.Text = "Name";
            // 
            // btnNextOne
            // 
            this.btnNextOne.Location = new System.Drawing.Point(360, 181);
            this.btnNextOne.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextOne.Name = "btnNextOne";
            this.btnNextOne.Size = new System.Drawing.Size(81, 26);
            this.btnNextOne.TabIndex = 20;
            this.btnNextOne.Text = "Add Book";
            this.btnNextOne.UseVisualStyleBackColor = true;
            this.btnNextOne.Click += new System.EventHandler(this.btnNextOne_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(513, 181);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 26);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(445, 181);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(64, 26);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "Borrow";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(116, 182);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(229, 20);
            this.dtpDueDate.TabIndex = 12;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Location = new System.Drawing.Point(116, 145);
            this.dtpIssueDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(229, 20);
            this.dtpIssueDate.TabIndex = 11;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(360, 103);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(213, 55);
            this.txtRemark.TabIndex = 14;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(357, 24);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.Size = new System.Drawing.Size(129, 20);
            this.txtEmployeeID.TabIndex = 116;
            this.txtEmployeeID.TabStop = false;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(360, 61);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(126, 20);
            this.txtMemberID.TabIndex = 13;
            this.txtMemberID.Leave += new System.EventHandler(this.txtMemberID_Leave);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(116, 118);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(129, 20);
            this.txtCategory.TabIndex = 112;
            this.txtCategory.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(116, 90);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(129, 20);
            this.txtTitle.TabIndex = 115;
            this.txtTitle.TabStop = false;
            // 
            // txtBookNumber
            // 
            this.txtBookNumber.Location = new System.Drawing.Point(116, 57);
            this.txtBookNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookNumber.Name = "txtBookNumber";
            this.txtBookNumber.Size = new System.Drawing.Size(129, 20);
            this.txtBookNumber.TabIndex = 10;
            this.txtBookNumber.Leave += new System.EventHandler(this.txtBookNumber_Leave);
            // 
            // txtIssueID
            // 
            this.txtIssueID.Location = new System.Drawing.Point(116, 24);
            this.txtIssueID.Margin = new System.Windows.Forms.Padding(2);
            this.txtIssueID.Name = "txtIssueID";
            this.txtIssueID.ReadOnly = true;
            this.txtIssueID.Size = new System.Drawing.Size(129, 20);
            this.txtIssueID.TabIndex = 109;
            this.txtIssueID.TabStop = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(23, 118);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(77, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Book Category";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(23, 175);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(53, 13);
            this.lblDueDate.TabIndex = 7;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(23, 145);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(58, 13);
            this.lblIssueDate.TabIndex = 6;
            this.lblIssueDate.Text = "Issue Date";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(272, 107);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(44, 13);
            this.lblRemark.TabIndex = 5;
            this.lblRemark.Text = "Remark";
            // 
            // lblStaffNumber
            // 
            this.lblStaffNumber.AutoSize = true;
            this.lblStaffNumber.Location = new System.Drawing.Point(264, 24);
            this.lblStaffNumber.Name = "lblStaffNumber";
            this.lblStaffNumber.Size = new System.Drawing.Size(67, 13);
            this.lblStaffNumber.TabIndex = 4;
            this.lblStaffNumber.Text = "Employee ID";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(267, 61);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(59, 13);
            this.lblMemberID.TabIndex = 3;
            this.lblMemberID.Text = "Member ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(23, 90);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Book Title";
            // 
            // lblBookNumber
            // 
            this.lblBookNumber.AutoSize = true;
            this.lblBookNumber.Location = new System.Drawing.Point(23, 57);
            this.lblBookNumber.Name = "lblBookNumber";
            this.lblBookNumber.Size = new System.Drawing.Size(60, 13);
            this.lblBookNumber.TabIndex = 1;
            this.lblBookNumber.Text = "Book ISBN";
            // 
            // lblIssueNumber
            // 
            this.lblIssueNumber.AutoSize = true;
            this.lblIssueNumber.Location = new System.Drawing.Point(23, 24);
            this.lblIssueNumber.Name = "lblIssueNumber";
            this.lblIssueNumber.Size = new System.Drawing.Size(46, 13);
            this.lblIssueNumber.TabIndex = 0;
            this.lblIssueNumber.Text = "Issue ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(101, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 70);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // FormIssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupIssueBook);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormIssueBook";
            this.Text = "FormIssueBook";
            this.Load += new System.EventHandler(this.FormIssueBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupIssueBook.ResumeLayout(false);
            this.groupIssueBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupIssueBook;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtMemberType;
        private System.Windows.Forms.Label lblMemberCategory;
        private System.Windows.Forms.Button btnNextOne;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBookNumber;
        private System.Windows.Forms.TextBox txtIssueID;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblStaffNumber;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBookNumber;
        private System.Windows.Forms.Label lblIssueNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}