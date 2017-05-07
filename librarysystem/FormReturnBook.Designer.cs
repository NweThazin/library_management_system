namespace SA43Team4B
{
    partial class FormReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReturnBook));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.btnReturnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtIssueID = new System.Windows.Forms.TextBox();
            this.lblIssueID = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvReturnList = new System.Windows.Forms.DataGridView();
            this.grpReturnlists = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnList)).BeginInit();
            this.grpReturnlists.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblMemberID);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.txtDueDate);
            this.groupBox1.Controls.Add(this.txtMemberID);
            this.groupBox1.Controls.Add(this.btnReturnNext);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIssueDate);
            this.groupBox1.Controls.Add(this.dtpReturnDate);
            this.groupBox1.Controls.Add(this.txtIssueID);
            this.groupBox1.Controls.Add(this.lblIssueID);
            this.groupBox1.Controls.Add(this.txtBookTitle);
            this.groupBox1.Controls.Add(this.txtBookID);
            this.groupBox1.Controls.Add(this.lblReturnDate);
            this.groupBox1.Controls.Add(this.lblDueDate);
            this.groupBox1.Controls.Add(this.lblIssueDate);
            this.groupBox1.Controls.Add(this.lblBookTitle);
            this.groupBox1.Controls.Add(this.lblBookID);
            this.groupBox1.Location = new System.Drawing.Point(163, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(626, 222);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Book";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(263, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search Record";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(20, 35);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(59, 13);
            this.lblMemberID.TabIndex = 24;
            this.lblMemberID.Text = "Member ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(384, 182);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 26);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(117, 61);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(141, 20);
            this.txtMemberName.TabIndex = 27;
            this.txtMemberName.TabStop = false;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(384, 126);
            this.txtDueDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ReadOnly = true;
            this.txtDueDate.Size = new System.Drawing.Size(219, 20);
            this.txtDueDate.TabIndex = 18;
            this.txtDueDate.TabStop = false;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(117, 32);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(141, 20);
            this.txtMemberID.TabIndex = 21;
            // 
            // btnReturnNext
            // 
            this.btnReturnNext.Location = new System.Drawing.Point(530, 182);
            this.btnReturnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnNext.Name = "btnReturnNext";
            this.btnReturnNext.Size = new System.Drawing.Size(73, 26);
            this.btnReturnNext.TabIndex = 41;
            this.btnReturnNext.Text = "Return";
            this.btnReturnNext.UseVisualStyleBackColor = true;
            this.btnReturnNext.Click += new System.EventHandler(this.btnReturnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Member Name";
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.Location = new System.Drawing.Point(384, 99);
            this.txtIssueDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.ReadOnly = true;
            this.txtIssueDate.Size = new System.Drawing.Size(219, 20);
            this.txtIssueDate.TabIndex = 17;
            this.txtIssueDate.TabStop = false;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(384, 152);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(219, 20);
            this.dtpReturnDate.TabIndex = 31;
            // 
            // txtIssueID
            // 
            this.txtIssueID.Location = new System.Drawing.Point(117, 98);
            this.txtIssueID.Margin = new System.Windows.Forms.Padding(2);
            this.txtIssueID.Name = "txtIssueID";
            this.txtIssueID.ReadOnly = true;
            this.txtIssueID.Size = new System.Drawing.Size(141, 20);
            this.txtIssueID.TabIndex = 14;
            this.txtIssueID.TabStop = false;
            // 
            // lblIssueID
            // 
            this.lblIssueID.AutoSize = true;
            this.lblIssueID.Location = new System.Drawing.Point(20, 99);
            this.lblIssueID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIssueID.Name = "lblIssueID";
            this.lblIssueID.Size = new System.Drawing.Size(46, 13);
            this.lblIssueID.TabIndex = 13;
            this.lblIssueID.Text = "Issue ID";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(117, 159);
            this.txtBookTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.ReadOnly = true;
            this.txtBookTitle.Size = new System.Drawing.Size(141, 20);
            this.txtBookTitle.TabIndex = 11;
            this.txtBookTitle.TabStop = false;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(117, 125);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(141, 20);
            this.txtBookID.TabIndex = 7;
            this.txtBookID.TabStop = false;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(303, 155);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(65, 13);
            this.lblReturnDate.TabIndex = 5;
            this.lblReturnDate.Text = "Return Date";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(303, 128);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(53, 13);
            this.lblDueDate.TabIndex = 4;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(303, 101);
            this.lblIssueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(58, 13);
            this.lblIssueDate.TabIndex = 3;
            this.lblIssueDate.Text = "Issue Date";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(20, 159);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(55, 13);
            this.lblBookTitle.TabIndex = 2;
            this.lblBookTitle.Text = "Book Title";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(21, 127);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(60, 13);
            this.lblBookID.TabIndex = 1;
            this.lblBookID.Text = "Book ISBN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(147, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 70);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // dgvReturnList
            // 
            this.dgvReturnList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnList.Location = new System.Drawing.Point(0, 19);
            this.dgvReturnList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReturnList.Name = "dgvReturnList";
            this.dgvReturnList.ReadOnly = true;
            this.dgvReturnList.RowTemplate.Height = 28;
            this.dgvReturnList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnList.Size = new System.Drawing.Size(615, 184);
            this.dgvReturnList.TabIndex = 0;
            this.dgvReturnList.SelectionChanged += new System.EventHandler(this.dgvReturnList_SelectARow);
            // 
            // grpReturnlists
            // 
            this.grpReturnlists.Controls.Add(this.dgvReturnList);
            this.grpReturnlists.Location = new System.Drawing.Point(163, 340);
            this.grpReturnlists.Margin = new System.Windows.Forms.Padding(2);
            this.grpReturnlists.Name = "grpReturnlists";
            this.grpReturnlists.Padding = new System.Windows.Forms.Padding(2);
            this.grpReturnlists.Size = new System.Drawing.Size(626, 212);
            this.grpReturnlists.TabIndex = 20;
            this.grpReturnlists.TabStop = false;
            this.grpReturnlists.Text = "Return Book Lists";
            // 
            // FormReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpReturnlists);
            this.Name = "FormReturnBook";
            this.Text = "Return Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnList)).EndInit();
            this.grpReturnlists.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturnNext;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.TextBox txtIssueDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.TextBox txtIssueID;
        private System.Windows.Forms.Label lblIssueID;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvReturnList;
        private System.Windows.Forms.GroupBox grpReturnlists;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
    }
}