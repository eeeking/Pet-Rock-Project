namespace PetRock
{
    partial class frmCreateAccount
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPass1 = new System.Windows.Forms.Label();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.lblFirstError = new System.Windows.Forms.Label();
            this.lblLastError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblPassError1 = new System.Windows.Forms.Label();
            this.lblPassError2 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblNoteEmail = new System.Windows.Forms.Label();
            this.lblNotePassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(25, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstName_KeyDown);
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(153, 43);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Enter += new System.EventHandler(this.txtLastName_Enter);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(22, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(25, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblPass1
            // 
            this.lblPass1.AutoSize = true;
            this.lblPass1.Location = new System.Drawing.Point(22, 155);
            this.lblPass1.Name = "lblPass1";
            this.lblPass1.Size = new System.Drawing.Size(95, 13);
            this.lblPass1.TabIndex = 3;
            this.lblPass1.Text = "Create a password";
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(25, 171);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '*';
            this.txtPass1.Size = new System.Drawing.Size(228, 20);
            this.txtPass1.TabIndex = 3;
            this.txtPass1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass1_KeyPress);
            this.txtPass1.Leave += new System.EventHandler(this.txtPass1_Leave);
            // 
            // lblPass2
            // 
            this.lblPass2.AutoSize = true;
            this.lblPass2.Location = new System.Drawing.Point(22, 217);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(113, 13);
            this.lblPass2.TabIndex = 5;
            this.lblPass2.Text = "Confirm your password";
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(25, 233);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(228, 20);
            this.txtPass2.TabIndex = 4;
            this.txtPass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass2_KeyPress);
            this.txtPass2.Leave += new System.EventHandler(this.txtPass2_Leave);
            // 
            // lblFirstError
            // 
            this.lblFirstError.AutoSize = true;
            this.lblFirstError.ForeColor = System.Drawing.Color.Red;
            this.lblFirstError.Location = new System.Drawing.Point(22, 66);
            this.lblFirstError.Name = "lblFirstError";
            this.lblFirstError.Size = new System.Drawing.Size(0, 13);
            this.lblFirstError.TabIndex = 7;
            this.lblFirstError.Visible = false;
            // 
            // lblLastError
            // 
            this.lblLastError.AutoSize = true;
            this.lblLastError.ForeColor = System.Drawing.Color.Red;
            this.lblLastError.Location = new System.Drawing.Point(153, 67);
            this.lblLastError.Name = "lblLastError";
            this.lblLastError.Size = new System.Drawing.Size(0, 13);
            this.lblLastError.TabIndex = 8;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(22, 128);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(0, 13);
            this.lblEmailError.TabIndex = 9;
            // 
            // lblPassError1
            // 
            this.lblPassError1.AutoSize = true;
            this.lblPassError1.ForeColor = System.Drawing.Color.Red;
            this.lblPassError1.Location = new System.Drawing.Point(22, 194);
            this.lblPassError1.Name = "lblPassError1";
            this.lblPassError1.Size = new System.Drawing.Size(0, 13);
            this.lblPassError1.TabIndex = 10;
            // 
            // lblPassError2
            // 
            this.lblPassError2.AutoSize = true;
            this.lblPassError2.ForeColor = System.Drawing.Color.Red;
            this.lblPassError2.Location = new System.Drawing.Point(22, 256);
            this.lblPassError2.Name = "lblPassError2";
            this.lblPassError2.Size = new System.Drawing.Size(0, 13);
            this.lblPassError2.TabIndex = 11;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(89, 284);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(92, 23);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblNoteEmail
            // 
            this.lblNoteEmail.AutoSize = true;
            this.lblNoteEmail.Location = new System.Drawing.Point(260, 111);
            this.lblNoteEmail.Name = "lblNoteEmail";
            this.lblNoteEmail.Size = new System.Drawing.Size(166, 13);
            this.lblNoteEmail.TabIndex = 12;
            this.lblNoteEmail.Text = "Note: This will be your login email.";
            // 
            // lblNotePassword
            // 
            this.lblNotePassword.AutoSize = true;
            this.lblNotePassword.Location = new System.Drawing.Point(260, 174);
            this.lblNotePassword.Name = "lblNotePassword";
            this.lblNotePassword.Size = new System.Drawing.Size(179, 13);
            this.lblNotePassword.TabIndex = 13;
            this.lblNotePassword.Text = "Note: At least 8 characters in length.";
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 325);
            this.Controls.Add(this.lblNotePassword);
            this.Controls.Add(this.lblNoteEmail);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.lblPassError2);
            this.Controls.Add(this.lblPassError1);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.lblLastError);
            this.Controls.Add(this.lblFirstError);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.lblPass2);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.lblPass1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.frmCreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPass1;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.Label lblFirstError;
        private System.Windows.Forms.Label lblLastError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblPassError1;
        private System.Windows.Forms.Label lblPassError2;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblNoteEmail;
        private System.Windows.Forms.Label lblNotePassword;
    }
}