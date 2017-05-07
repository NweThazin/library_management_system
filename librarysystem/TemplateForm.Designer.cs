namespace SA43Team4B
{
    partial class TemplateForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookListReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookCategoryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.bookToolStripMenuItem,
            this.memberToolStripMenuItem,
            this.doTransactionToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1089, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(88, 21);
            this.toolStripMenuItem1.Text = "Main Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchBookToolStripMenuItem,
            this.modifyBookToolStripMenuItem,
            this.searchBookToolStripMenuItem2});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.bookToolStripMenuItem.Text = "Books";
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.searchBookToolStripMenuItem.Text = "Add Book";
            this.searchBookToolStripMenuItem.Click += new System.EventHandler(this.AddBookToolStripMenuItem_Click);
            // 
            // modifyBookToolStripMenuItem
            // 
            this.modifyBookToolStripMenuItem.Name = "modifyBookToolStripMenuItem";
            this.modifyBookToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.modifyBookToolStripMenuItem.Text = "Modify Book";
            this.modifyBookToolStripMenuItem.Click += new System.EventHandler(this.modifyBookToolStripMenuItem_Click);
            // 
            // searchBookToolStripMenuItem2
            // 
            this.searchBookToolStripMenuItem2.Name = "searchBookToolStripMenuItem2";
            this.searchBookToolStripMenuItem2.Size = new System.Drawing.Size(153, 22);
            this.searchBookToolStripMenuItem2.Text = "Search Book";
            this.searchBookToolStripMenuItem2.Click += new System.EventHandler(this.searchBookToolStripMenuItem2_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMemberToolStripMenuItem,
            this.modifyMemberToolStripMenuItem});
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.memberToolStripMenuItem.Text = "Members";
            // 
            // addNewMemberToolStripMenuItem
            // 
            this.addNewMemberToolStripMenuItem.Name = "addNewMemberToolStripMenuItem";
            this.addNewMemberToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addNewMemberToolStripMenuItem.Text = "Add New Member";
            this.addNewMemberToolStripMenuItem.Click += new System.EventHandler(this.addNewMemberToolStripMenuItem_Click);
            // 
            // modifyMemberToolStripMenuItem
            // 
            this.modifyMemberToolStripMenuItem.Name = "modifyMemberToolStripMenuItem";
            this.modifyMemberToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.modifyMemberToolStripMenuItem.Text = "Modify Member";
            this.modifyMemberToolStripMenuItem.Click += new System.EventHandler(this.modifyMemberToolStripMenuItem_Click);
            // 
            // doTransactionToolStripMenuItem
            // 
            this.doTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueBookToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.doTransactionToolStripMenuItem.Name = "doTransactionToolStripMenuItem";
            this.doTransactionToolStripMenuItem.Size = new System.Drawing.Size(94, 21);
            this.doTransactionToolStripMenuItem.Text = "Transactions";
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.issueBookToolStripMenuItem.Text = "Issue Book";
            this.issueBookToolStripMenuItem.Click += new System.EventHandler(this.issueBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookListReportToolStripMenuItem,
            this.bookCategoryReportToolStripMenuItem,
            this.managementReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // bookListReportToolStripMenuItem
            // 
            this.bookListReportToolStripMenuItem.Name = "bookListReportToolStripMenuItem";
            this.bookListReportToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.bookListReportToolStripMenuItem.Text = "Book List Report";
            this.bookListReportToolStripMenuItem.Click += new System.EventHandler(this.bookListReportToolStripMenuItem_Click);
            // 
            // bookCategoryReportToolStripMenuItem
            // 
            this.bookCategoryReportToolStripMenuItem.Name = "bookCategoryReportToolStripMenuItem";
            this.bookCategoryReportToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.bookCategoryReportToolStripMenuItem.Text = "Book Category Report";
            this.bookCategoryReportToolStripMenuItem.Click += new System.EventHandler(this.bookCategoryReportToolStripMenuItem_Click);
            // 
            // managementReportToolStripMenuItem
            // 
            this.managementReportToolStripMenuItem.Name = "managementReportToolStripMenuItem";
            this.managementReportToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.managementReportToolStripMenuItem.Text = "Management Report";
            this.managementReportToolStripMenuItem.Click += new System.EventHandler(this.managementReportToolStripMenuItem_Click);
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 700);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TemplateForm";
            this.Text = "TemplateForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TemplateForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookListReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookCategoryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}