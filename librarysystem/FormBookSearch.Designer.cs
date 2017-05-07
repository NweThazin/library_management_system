namespace SA43Team4B
{
    partial class FormBookSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookSearch));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtAvailability = new System.Windows.Forms.TextBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 56);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // groupSearch
            // 
            this.groupSearch.Controls.Add(this.btnQuery);
            this.groupSearch.Controls.Add(this.cboCategory);
            this.groupSearch.Controls.Add(this.lblCategory);
            this.groupSearch.Controls.Add(this.txtAvailability);
            this.groupSearch.Controls.Add(this.lblAvailability);
            this.groupSearch.Controls.Add(this.btnClear);
            this.groupSearch.Controls.Add(this.btnSearch);
            this.groupSearch.Controls.Add(this.txtAuthor);
            this.groupSearch.Controls.Add(this.lblAuthor);
            this.groupSearch.Controls.Add(this.txtTitle);
            this.groupSearch.Controls.Add(this.lblBookTitle);
            this.groupSearch.Location = new System.Drawing.Point(16, 72);
            this.groupSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupSearch.Size = new System.Drawing.Size(718, 82);
            this.groupSearch.TabIndex = 17;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Search By Book";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(522, 21);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(89, 25);
            this.btnQuery.TabIndex = 18;
            this.btnQuery.Text = "Query";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(381, 48);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(125, 21);
            this.cboCategory.TabIndex = 17;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(267, 48);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(77, 13);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Book Category";
            // 
            // txtAvailability
            // 
            this.txtAvailability.Location = new System.Drawing.Point(381, 23);
            this.txtAvailability.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.ReadOnly = true;
            this.txtAvailability.Size = new System.Drawing.Size(125, 20);
            this.txtAvailability.TabIndex = 13;
            this.txtAvailability.Leave += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(267, 25);
            this.lblAvailability.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(92, 13);
            this.lblAvailability.TabIndex = 12;
            this.lblAvailability.Text = "Available for Loan";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(615, 49);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 27);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear Search";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(615, 19);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 27);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(96, 46);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(125, 20);
            this.txtAuthor.TabIndex = 7;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(5, 48);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(66, 13);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Book Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(96, 23);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(125, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(7, 25);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(55, 13);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "Book Title";
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(16, 160);
            this.dataGridViewSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.ReadOnly = true;
            this.dataGridViewSearch.RowTemplate.Height = 28;
            this.dataGridViewSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearch.Size = new System.Drawing.Size(718, 228);
            this.dataGridViewSearch.TabIndex = 18;
            this.dataGridViewSearch.SelectionChanged += new System.EventHandler(this.dataGridViewSearch_CellContentClick);
            // 
            // FormBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupSearch);
            this.Controls.Add(this.dataGridViewSearch);
            this.Name = "FormBookSearch";
            this.Text = "FormBookSearch";
            this.Load += new System.EventHandler(this.FormBookSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtAvailability;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
    }
}