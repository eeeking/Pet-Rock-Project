namespace PetRock
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.txtWelcome = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.picGrass = new System.Windows.Forms.PictureBox();
            this.linkLblCreateAccount = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picGrass)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWelcome
            // 
            this.txtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.Location = new System.Drawing.Point(277, 137);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(563, 28);
            this.txtWelcome.TabIndex = 1;
            this.txtWelcome.Text = "Welcome! Start Building Your Own Pet Rock Now!!";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.Image = ((System.Drawing.Image)(resources.GetObject("btnEnter.Image")));
            this.btnEnter.Location = new System.Drawing.Point(348, 186);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(388, 432);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // picGrass
            // 
            this.picGrass.Image = ((System.Drawing.Image)(resources.GetObject("picGrass.Image")));
            this.picGrass.Location = new System.Drawing.Point(57, 79);
            this.picGrass.Name = "picGrass";
            this.picGrass.Size = new System.Drawing.Size(1000, 563);
            this.picGrass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGrass.TabIndex = 3;
            this.picGrass.TabStop = false;
            // 
            // linkLblCreateAccount
            // 
            this.linkLblCreateAccount.AutoSize = true;
            this.linkLblCreateAccount.Location = new System.Drawing.Point(827, 287);
            this.linkLblCreateAccount.Name = "linkLblCreateAccount";
            this.linkLblCreateAccount.Size = new System.Drawing.Size(81, 13);
            this.linkLblCreateAccount.TabIndex = 4;
            this.linkLblCreateAccount.TabStop = true;
            this.linkLblCreateAccount.Text = "Create Account";
            this.linkLblCreateAccount.Visible = false;
            this.linkLblCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblCreateAccount_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(847, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLblCreateAccount);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.picGrass);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome, Build Your Own Pet Rock!!";
            ((System.ComponentModel.ISupportInitialize)(this.picGrass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtWelcome;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.PictureBox picGrass;
        private System.Windows.Forms.LinkLabel linkLblCreateAccount;
        private System.Windows.Forms.Button button1;
    }
}

