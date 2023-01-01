namespace Account_Manager
{
    partial class AccountManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManager));
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.btnLogIn = new CustomControls.RJControls.RJButton();
            this.lblFPass = new System.Windows.Forms.Label();
            this.llbRecoverPass = new System.Windows.Forms.LinkLabel();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.llbSignUp = new System.Windows.Forms.LinkLabel();
            this.lblQst = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.btnCancel = new CustomControls.RJControls.RJButton();
            this.btnSave = new CustomControls.RJControls.RJButton();
            this.txtNUserName = new System.Windows.Forms.TextBox();
            this.lblNUserName = new System.Windows.Forms.Label();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.txtNPassword = new System.Windows.Forms.TextBox();
            this.lblNPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAccountManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblAccountManager = new System.Windows.Forms.Label();
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnExit = new CustomControls.RJControls.RJButton();
            this.pnlLogIn.SuspendLayout();
            this.pnlSignUp.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.pnlLogIn.Controls.Add(this.btnLogIn);
            this.pnlLogIn.Controls.Add(this.lblFPass);
            this.pnlLogIn.Controls.Add(this.llbRecoverPass);
            this.pnlLogIn.Controls.Add(this.btnShowHide);
            this.pnlLogIn.Controls.Add(this.llbSignUp);
            this.pnlLogIn.Controls.Add(this.lblQst);
            this.pnlLogIn.Controls.Add(this.txtPassword);
            this.pnlLogIn.Controls.Add(this.lblPassword);
            this.pnlLogIn.Controls.Add(this.txtUserName);
            this.pnlLogIn.Controls.Add(this.lblUsername);
            resources.ApplyResources(this.pnlLogIn, "pnlLogIn");
            this.pnlLogIn.Name = "pnlLogIn";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.btnLogIn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.btnLogIn.BorderColor = System.Drawing.Color.Empty;
            this.btnLogIn.BorderRadius = 15;
            this.btnLogIn.BorderSize = 1;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnLogIn, "btnLogIn");
            this.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblFPass
            // 
            resources.ApplyResources(this.lblFPass, "lblFPass");
            this.lblFPass.Name = "lblFPass";
            // 
            // llbRecoverPass
            // 
            this.llbRecoverPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            resources.ApplyResources(this.llbRecoverPass, "llbRecoverPass");
            this.llbRecoverPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.llbRecoverPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.llbRecoverPass.Name = "llbRecoverPass";
            this.llbRecoverPass.TabStop = true;
            // 
            // btnShowHide
            // 
            this.btnShowHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.btnShowHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowHide.Image = global::Account_Manager.Properties.Resources.show;
            resources.ApplyResources(this.btnShowHide, "btnShowHide");
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.UseVisualStyleBackColor = false;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // llbSignUp
            // 
            this.llbSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            resources.ApplyResources(this.llbSignUp, "llbSignUp");
            this.llbSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.llbSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.llbSignUp.Name = "llbSignUp";
            this.llbSignUp.TabStop = true;
            this.llbSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSignUp_LinkClicked);
            // 
            // lblQst
            // 
            resources.ApplyResources(this.lblQst, "lblQst");
            this.lblQst.Name = "lblQst";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.Name = "lblUsername";
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.pnlSignUp.Controls.Add(this.btnCancel);
            this.pnlSignUp.Controls.Add(this.btnSave);
            this.pnlSignUp.Controls.Add(this.txtNUserName);
            this.pnlSignUp.Controls.Add(this.lblNUserName);
            this.pnlSignUp.Controls.Add(this.lblCreateAccount);
            this.pnlSignUp.Controls.Add(this.txtRePassword);
            this.pnlSignUp.Controls.Add(this.lblRePassword);
            this.pnlSignUp.Controls.Add(this.txtNPassword);
            this.pnlSignUp.Controls.Add(this.lblNPassword);
            this.pnlSignUp.Controls.Add(this.txtEmail);
            this.pnlSignUp.Controls.Add(this.lblEmail);
            this.pnlSignUp.Controls.Add(this.txtLastName);
            this.pnlSignUp.Controls.Add(this.lblLastName);
            this.pnlSignUp.Controls.Add(this.txtFirstName);
            this.pnlSignUp.Controls.Add(this.lblFirstName);
            this.pnlSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            resources.ApplyResources(this.pnlSignUp, "pnlSignUp");
            this.pnlSignUp.Name = "pnlSignUp";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Empty;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.btnSave.BorderColor = System.Drawing.Color.Empty;
            this.btnSave.BorderRadius = 15;
            this.btnSave.BorderSize = 1;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnSave.Name = "btnSave";
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNUserName
            // 
            this.txtNUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtNUserName, "txtNUserName");
            this.txtNUserName.Name = "txtNUserName";
            // 
            // lblNUserName
            // 
            resources.ApplyResources(this.lblNUserName, "lblNUserName");
            this.lblNUserName.Name = "lblNUserName";
            // 
            // lblCreateAccount
            // 
            resources.ApplyResources(this.lblCreateAccount, "lblCreateAccount");
            this.lblCreateAccount.Name = "lblCreateAccount";
            // 
            // txtRePassword
            // 
            this.txtRePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtRePassword, "txtRePassword");
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.UseSystemPasswordChar = true;
            // 
            // lblRePassword
            // 
            resources.ApplyResources(this.lblRePassword, "lblRePassword");
            this.lblRePassword.Name = "lblRePassword";
            // 
            // txtNPassword
            // 
            this.txtNPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtNPassword, "txtNPassword");
            this.txtNPassword.Name = "txtNPassword";
            this.txtNPassword.UseSystemPasswordChar = true;
            // 
            // lblNPassword
            // 
            resources.ApplyResources(this.lblNPassword, "lblNPassword");
            this.lblNPassword.Name = "lblNPassword";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.txtLastName.Name = "txtLastName";
            // 
            // lblLastName
            // 
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.lblLastName.Name = "lblLastName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.txtFirstName.Name = "txtFirstName";
            // 
            // lblFirstName
            // 
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.lblFirstName.Name = "lblFirstName";
            // 
            // lblOutPut
            // 
            resources.ApplyResources(this.lblOutPut, "lblOutPut");
            this.lblOutPut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.lblOutPut.Name = "lblOutPut";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAccountManagerToolStripMenuItem});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // aboutAccountManagerToolStripMenuItem
            // 
            this.aboutAccountManagerToolStripMenuItem.Name = "aboutAccountManagerToolStripMenuItem";
            resources.ApplyResources(this.aboutAccountManagerToolStripMenuItem, "aboutAccountManagerToolStripMenuItem");
            this.aboutAccountManagerToolStripMenuItem.Click += new System.EventHandler(this.aboutAccountManagerToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.lblCopyright);
            this.panel1.Controls.Add(this.lblAccountManager);
            this.panel1.Controls.Add(this.btnLogo);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblCopyright
            // 
            resources.ApplyResources(this.lblCopyright, "lblCopyright");
            this.lblCopyright.Name = "lblCopyright";
            // 
            // lblAccountManager
            // 
            resources.ApplyResources(this.lblAccountManager, "lblAccountManager");
            this.lblAccountManager.Name = "lblAccountManager";
            // 
            // btnLogo
            // 
            resources.ApplyResources(this.btnLogo, "btnLogo");
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.Image = global::Account_Manager.Properties.Resources.logo;
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.btnExit.BorderColor = System.Drawing.Color.Empty;
            this.btnExit.BorderRadius = 15;
            this.btnExit.BorderSize = 1;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnExit.Name = "btnExit";
            this.btnExit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AccountManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSignUp);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.pnlLogIn);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AccountManager";
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogIn;
        private System.Windows.Forms.LinkLabel llbSignUp;
        private System.Windows.Forms.Label lblQst;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.TextBox txtNPassword;
        private System.Windows.Forms.Label lblNPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label lblOutPut;
        private System.Windows.Forms.TextBox txtNUserName;
        private System.Windows.Forms.Label lblNUserName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAccountManagerToolStripMenuItem;
        private System.Windows.Forms.Label lblFPass;
        private System.Windows.Forms.LinkLabel llbRecoverPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblAccountManager;
        private System.Windows.Forms.Button btnLogo;
        private CustomControls.RJControls.RJButton btnSave;
        private CustomControls.RJControls.RJButton btnLogIn;
        private CustomControls.RJControls.RJButton btnCancel;
        private CustomControls.RJControls.RJButton btnExit;
    }
}

