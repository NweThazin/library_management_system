namespace SA43Team4B
{
    partial class FormChangePassword
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
            this.labelCurrentPassword = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxCurrentPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCurrentPassword
            // 
            this.labelCurrentPassword.AutoSize = true;
            this.labelCurrentPassword.Location = new System.Drawing.Point(15, 140);
            this.labelCurrentPassword.Name = "labelCurrentPassword";
            this.labelCurrentPassword.Size = new System.Drawing.Size(93, 13);
            this.labelCurrentPassword.TabIndex = 5;
            this.labelCurrentPassword.Text = "Current Password:";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(15, 100);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(46, 13);
            this.labelUserID.TabIndex = 4;
            this.labelUserID.Text = "User ID:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(15, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(107, 26);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Welcome to eLibrary!\r\nChange Password";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(15, 180);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(81, 13);
            this.labelNewPassword.TabIndex = 6;
            this.labelNewPassword.Text = "New Password:";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(15, 220);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.labelConfirmPassword.TabIndex = 7;
            this.labelConfirmPassword.Text = "Confirm Password:";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(130, 95);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserID.TabIndex = 9;
            // 
            // textBoxCurrentPassword
            // 
            this.textBoxCurrentPassword.Location = new System.Drawing.Point(130, 135);
            this.textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            this.textBoxCurrentPassword.PasswordChar = '*';
            this.textBoxCurrentPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentPassword.TabIndex = 10;
            this.textBoxCurrentPassword.TextChanged += new System.EventHandler(this.textBoxCurrentPassword_TextChanged);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(130, 175);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewPassword.TabIndex = 11;
            this.textBoxNewPassword.TextChanged += new System.EventHandler(this.textBoxNewPassword_TextChanged);
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(130, 215);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxConfirmPassword.TabIndex = 12;
            this.textBoxConfirmPassword.TextChanged += new System.EventHandler(this.textBoxConfirmPassword_TextChanged);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(50, 295);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 13;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(135, 295);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormChangePassword
            // 
            this.AcceptButton = this.buttonCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(249, 347);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxCurrentPassword);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.labelCurrentPassword);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.Name = "FormChangePassword";
            this.Text = "FormChangePassword";
            this.Load += new System.EventHandler(this.FormChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentPassword;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxCurrentPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
    }
}