namespace SA43Team4B
{
    partial class FormMemberMain
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
            this.myELibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myELibraryToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myELibraryToolStripMenuItem
            // 
            this.myELibraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myStatusToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.myELibraryToolStripMenuItem.Name = "myELibraryToolStripMenuItem";
            this.myELibraryToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.myELibraryToolStripMenuItem.Text = "My eLibrary";
            // 
            // myStatusToolStripMenuItem
            // 
            this.myStatusToolStripMenuItem.Name = "myStatusToolStripMenuItem";
            this.myStatusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.myStatusToolStripMenuItem.Text = "My Records";
            this.myStatusToolStripMenuItem.Click += new System.EventHandler(this.myStatusToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookSearchToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // bookSearchToolStripMenuItem
            // 
            this.bookSearchToolStripMenuItem.Name = "bookSearchToolStripMenuItem";
            this.bookSearchToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.bookSearchToolStripMenuItem.Text = "Book Search...";
            this.bookSearchToolStripMenuItem.Click += new System.EventHandler(this.bookSearchToolStripMenuItem_Click);
            // 
            // FormMemberMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMemberMain";
            this.Load += new System.EventHandler(this.FormMemberMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myELibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookSearchToolStripMenuItem;

    }
}

