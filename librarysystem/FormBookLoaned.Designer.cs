namespace SA43Team4B
{
    partial class FormBookLoaned
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
            this.dataGridViewBkLoan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBkLoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBkLoan
            // 
            this.dataGridViewBkLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBkLoan.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBkLoan.Name = "dataGridViewBkLoan";
            this.dataGridViewBkLoan.RowTemplate.Height = 28;
            this.dataGridViewBkLoan.Size = new System.Drawing.Size(1134, 343);
            this.dataGridViewBkLoan.TabIndex = 0;
            // 
            // FormBookLoaned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 367);
            this.Controls.Add(this.dataGridViewBkLoan);
            this.Name = "FormBookLoaned";
            this.Text = "Books on Loan";
            this.Load += new System.EventHandler(this.FormBookLoaned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBkLoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBkLoan;
    }
}