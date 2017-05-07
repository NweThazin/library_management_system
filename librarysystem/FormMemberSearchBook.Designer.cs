namespace SA43Team4B
{
    partial class FormMemberSearchBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.textBoxBookCategory = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(491, 8);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Search!";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(85, 10);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(100, 20);
            this.textBoxISBN.TabIndex = 5;
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(85, 38);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxBookTitle.TabIndex = 6;
            // 
            // textBoxBookCategory
            // 
            this.textBoxBookCategory.Location = new System.Drawing.Point(309, 10);
            this.textBoxBookCategory.Name = "textBoxBookCategory";
            this.textBoxBookCategory.Size = new System.Drawing.Size(100, 20);
            this.textBoxBookCategory.TabIndex = 7;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(309, 38);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuthor.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 256);
            this.dataGridView1.TabIndex = 9;
            // 
            // FormSearchBook
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 332);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxBookCategory);
            this.Controls.Add(this.textBoxBookTitle);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormSearchBook";
            this.Text = "Search Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSearchBook_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.TextBox textBoxBookCategory;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}