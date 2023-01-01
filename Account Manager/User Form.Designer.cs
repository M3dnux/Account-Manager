namespace Account_Manager
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAccountManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbPlatforms = new System.Windows.Forms.ComboBox();
            this.grpAccounts = new System.Windows.Forms.GroupBox();
            this.btnUCancel = new CustomControls.RJControls.RJButton();
            this.btnA = new CustomControls.RJControls.RJButton();
            this.btnUChecked = new CustomControls.RJControls.RJButton();
            this.btnDelete = new CustomControls.RJControls.RJButton();
            this.btnUpdate = new CustomControls.RJControls.RJButton();
            this.btnAddA = new System.Windows.Forms.Button();
            this.txtPUserName = new System.Windows.Forms.TextBox();
            this.lblPUserName = new System.Windows.Forms.Label();
            this.txtPPassword = new System.Windows.Forms.TextBox();
            this.txtPEmail = new System.Windows.Forms.TextBox();
            this.lblPPassword = new System.Windows.Forms.Label();
            this.lblPEmail = new System.Windows.Forms.Label();
            this.pnlViewAccounts = new System.Windows.Forms.Panel();
            this.grpAddPlat = new System.Windows.Forms.GroupBox();
            this.btnAPCancel = new System.Windows.Forms.Button();
            this.lblPlatName = new System.Windows.Forms.Label();
            this.btnAPConfirm = new System.Windows.Forms.Button();
            this.txtPlatName = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnAddPlat = new System.Windows.Forms.Button();
            this.pnlAddAccounts = new System.Windows.Forms.Panel();
            this.btnSaveAccounts = new CustomControls.RJControls.RJButton();
            this.btnCancelAddAccounts = new CustomControls.RJControls.RJButton();
            this.btnN = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.grpPAccounts = new System.Windows.Forms.GroupBox();
            this.btnMAccount = new CustomControls.RJControls.RJButton();
            this.btnAddAccount = new CustomControls.RJControls.RJButton();
            this.txtAPUserName = new System.Windows.Forms.TextBox();
            this.lblAPUserName = new System.Windows.Forms.Label();
            this.txtAPPassword = new System.Windows.Forms.TextBox();
            this.txtAPEmail = new System.Windows.Forms.TextBox();
            this.lblAPPassword = new System.Windows.Forms.Label();
            this.lblAPEmail = new System.Windows.Forms.Label();
            this.lblAddAccounts = new System.Windows.Forms.Label();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblAccountManager = new System.Windows.Forms.Label();
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnExit = new CustomControls.RJControls.RJButton();
            this.menuStrip1.SuspendLayout();
            this.grpAccounts.SuspendLayout();
            this.pnlViewAccounts.SuspendLayout();
            this.grpAddPlat.SuspendLayout();
            this.pnlAddAccounts.SuspendLayout();
            this.grpPAccounts.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // cmbPlatforms
            // 
            this.cmbPlatforms.FormattingEnabled = true;
            resources.ApplyResources(this.cmbPlatforms, "cmbPlatforms");
            this.cmbPlatforms.Name = "cmbPlatforms";
            this.cmbPlatforms.Sorted = true;
            this.cmbPlatforms.SelectedIndexChanged += new System.EventHandler(this.cmbPlatforms_SelectedIndexChanged);
            // 
            // grpAccounts
            // 
            this.grpAccounts.Controls.Add(this.btnUCancel);
            this.grpAccounts.Controls.Add(this.btnA);
            this.grpAccounts.Controls.Add(this.btnUChecked);
            this.grpAccounts.Controls.Add(this.btnDelete);
            this.grpAccounts.Controls.Add(this.btnUpdate);
            this.grpAccounts.Controls.Add(this.btnAddA);
            this.grpAccounts.Controls.Add(this.txtPUserName);
            this.grpAccounts.Controls.Add(this.lblPUserName);
            this.grpAccounts.Controls.Add(this.txtPPassword);
            this.grpAccounts.Controls.Add(this.txtPEmail);
            this.grpAccounts.Controls.Add(this.lblPPassword);
            this.grpAccounts.Controls.Add(this.lblPEmail);
            resources.ApplyResources(this.grpAccounts, "grpAccounts");
            this.grpAccounts.Name = "grpAccounts";
            this.grpAccounts.TabStop = false;
            // 
            // btnUCancel
            // 
            this.btnUCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnUCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnUCancel.BorderColor = System.Drawing.Color.Empty;
            this.btnUCancel.BorderRadius = 15;
            this.btnUCancel.BorderSize = 1;
            this.btnUCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUCancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnUCancel, "btnUCancel");
            this.btnUCancel.ForeColor = System.Drawing.Color.White;
            this.btnUCancel.Image = global::Account_Manager.Properties.Resources.cancel;
            this.btnUCancel.Name = "btnUCancel";
            this.btnUCancel.TextColor = System.Drawing.Color.White;
            this.btnUCancel.UseVisualStyleBackColor = false;
            this.btnUCancel.Click += new System.EventHandler(this.btnUCancel_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnA.BorderColor = System.Drawing.Color.Empty;
            this.btnA.BorderRadius = 15;
            this.btnA.BorderSize = 1;
            this.btnA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnA, "btnA");
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.Name = "btnA";
            this.btnA.TextColor = System.Drawing.Color.White;
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnUChecked
            // 
            this.btnUChecked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnUChecked.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnUChecked.BorderColor = System.Drawing.Color.Empty;
            this.btnUChecked.BorderRadius = 15;
            this.btnUChecked.BorderSize = 1;
            this.btnUChecked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUChecked.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnUChecked, "btnUChecked");
            this.btnUChecked.ForeColor = System.Drawing.Color.White;
            this.btnUChecked.Image = global::Account_Manager.Properties.Resources._checked;
            this.btnUChecked.Name = "btnUChecked";
            this.btnUChecked.TextColor = System.Drawing.Color.White;
            this.btnUChecked.UseVisualStyleBackColor = false;
            this.btnUChecked.Click += new System.EventHandler(this.btnUChecked_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Empty;
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.BorderSize = 1;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Empty;
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.BorderSize = 1;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddA
            // 
            this.btnAddA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAddA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddA.FlatAppearance.BorderSize = 0;
            this.btnAddA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAddA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            resources.ApplyResources(this.btnAddA, "btnAddA");
            this.btnAddA.ForeColor = System.Drawing.Color.White;
            this.btnAddA.Image = global::Account_Manager.Properties.Resources.add_user;
            this.btnAddA.Name = "btnAddA";
            this.btnAddA.UseVisualStyleBackColor = false;
            this.btnAddA.Click += new System.EventHandler(this.btnAddA_Click);
            // 
            // txtPUserName
            // 
            this.txtPUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPUserName, "txtPUserName");
            this.txtPUserName.Name = "txtPUserName";
            this.txtPUserName.ReadOnly = true;
            // 
            // lblPUserName
            // 
            resources.ApplyResources(this.lblPUserName, "lblPUserName");
            this.lblPUserName.Name = "lblPUserName";
            // 
            // txtPPassword
            // 
            this.txtPPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPPassword, "txtPPassword");
            this.txtPPassword.Name = "txtPPassword";
            this.txtPPassword.ReadOnly = true;
            // 
            // txtPEmail
            // 
            this.txtPEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPEmail, "txtPEmail");
            this.txtPEmail.Name = "txtPEmail";
            this.txtPEmail.ReadOnly = true;
            // 
            // lblPPassword
            // 
            resources.ApplyResources(this.lblPPassword, "lblPPassword");
            this.lblPPassword.Name = "lblPPassword";
            // 
            // lblPEmail
            // 
            resources.ApplyResources(this.lblPEmail, "lblPEmail");
            this.lblPEmail.Name = "lblPEmail";
            // 
            // pnlViewAccounts
            // 
            this.pnlViewAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.pnlViewAccounts.Controls.Add(this.grpAddPlat);
            this.pnlViewAccounts.Controls.Add(this.btnNext);
            this.pnlViewAccounts.Controls.Add(this.btnPrevious);
            this.pnlViewAccounts.Controls.Add(this.btnAddPlat);
            this.pnlViewAccounts.Controls.Add(this.cmbPlatforms);
            this.pnlViewAccounts.Controls.Add(this.grpAccounts);
            resources.ApplyResources(this.pnlViewAccounts, "pnlViewAccounts");
            this.pnlViewAccounts.Name = "pnlViewAccounts";
            // 
            // grpAddPlat
            // 
            this.grpAddPlat.Controls.Add(this.btnAPCancel);
            this.grpAddPlat.Controls.Add(this.lblPlatName);
            this.grpAddPlat.Controls.Add(this.btnAPConfirm);
            this.grpAddPlat.Controls.Add(this.txtPlatName);
            resources.ApplyResources(this.grpAddPlat, "grpAddPlat");
            this.grpAddPlat.Name = "grpAddPlat";
            this.grpAddPlat.TabStop = false;
            // 
            // btnAPCancel
            // 
            this.btnAPCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAPCancel.FlatAppearance.BorderSize = 0;
            this.btnAPCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAPCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            resources.ApplyResources(this.btnAPCancel, "btnAPCancel");
            this.btnAPCancel.ForeColor = System.Drawing.Color.White;
            this.btnAPCancel.Image = global::Account_Manager.Properties.Resources.cancel;
            this.btnAPCancel.Name = "btnAPCancel";
            this.btnAPCancel.UseVisualStyleBackColor = false;
            this.btnAPCancel.Click += new System.EventHandler(this.btnAPCancel_Click);
            // 
            // lblPlatName
            // 
            resources.ApplyResources(this.lblPlatName, "lblPlatName");
            this.lblPlatName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.lblPlatName.Name = "lblPlatName";
            // 
            // btnAPConfirm
            // 
            this.btnAPConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAPConfirm.FlatAppearance.BorderSize = 0;
            this.btnAPConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAPConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            resources.ApplyResources(this.btnAPConfirm, "btnAPConfirm");
            this.btnAPConfirm.ForeColor = System.Drawing.Color.White;
            this.btnAPConfirm.Image = global::Account_Manager.Properties.Resources._checked;
            this.btnAPConfirm.Name = "btnAPConfirm";
            this.btnAPConfirm.UseVisualStyleBackColor = false;
            this.btnAPConfirm.Click += new System.EventHandler(this.btnAPConfirm_Click);
            // 
            // txtPlatName
            // 
            this.txtPlatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPlatName, "txtPlatName");
            this.txtPlatName.Name = "txtPlatName";
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnNext.Image = global::Account_Manager.Properties.Resources.right_arrow;
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            resources.ApplyResources(this.btnPrevious, "btnPrevious");
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnPrevious.Image = global::Account_Manager.Properties.Resources.left_arrow;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnAddPlat
            // 
            resources.ApplyResources(this.btnAddPlat, "btnAddPlat");
            this.btnAddPlat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPlat.FlatAppearance.BorderSize = 0;
            this.btnAddPlat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAddPlat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAddPlat.ForeColor = System.Drawing.Color.White;
            this.btnAddPlat.Image = global::Account_Manager.Properties.Resources.cercle_plus;
            this.btnAddPlat.Name = "btnAddPlat";
            this.btnAddPlat.UseVisualStyleBackColor = false;
            this.btnAddPlat.Click += new System.EventHandler(this.btnAddPlat_Click);
            // 
            // pnlAddAccounts
            // 
            this.pnlAddAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.pnlAddAccounts.Controls.Add(this.btnSaveAccounts);
            this.pnlAddAccounts.Controls.Add(this.btnCancelAddAccounts);
            this.pnlAddAccounts.Controls.Add(this.btnN);
            this.pnlAddAccounts.Controls.Add(this.btnP);
            this.pnlAddAccounts.Controls.Add(this.grpPAccounts);
            this.pnlAddAccounts.Controls.Add(this.lblAddAccounts);
            this.pnlAddAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pnlAddAccounts, "pnlAddAccounts");
            this.pnlAddAccounts.Name = "pnlAddAccounts";
            // 
            // btnSaveAccounts
            // 
            this.btnSaveAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSaveAccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSaveAccounts.BorderColor = System.Drawing.Color.Empty;
            this.btnSaveAccounts.BorderRadius = 15;
            this.btnSaveAccounts.BorderSize = 1;
            this.btnSaveAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAccounts.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSaveAccounts, "btnSaveAccounts");
            this.btnSaveAccounts.ForeColor = System.Drawing.Color.White;
            this.btnSaveAccounts.Name = "btnSaveAccounts";
            this.btnSaveAccounts.TextColor = System.Drawing.Color.White;
            this.btnSaveAccounts.UseVisualStyleBackColor = false;
            this.btnSaveAccounts.Click += new System.EventHandler(this.btnSaveAccounts_Click);
            // 
            // btnCancelAddAccounts
            // 
            this.btnCancelAddAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnCancelAddAccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnCancelAddAccounts.BorderColor = System.Drawing.Color.Empty;
            this.btnCancelAddAccounts.BorderRadius = 15;
            this.btnCancelAddAccounts.BorderSize = 1;
            this.btnCancelAddAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAddAccounts.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCancelAddAccounts, "btnCancelAddAccounts");
            this.btnCancelAddAccounts.ForeColor = System.Drawing.Color.White;
            this.btnCancelAddAccounts.Name = "btnCancelAddAccounts";
            this.btnCancelAddAccounts.TextColor = System.Drawing.Color.White;
            this.btnCancelAddAccounts.UseVisualStyleBackColor = false;
            this.btnCancelAddAccounts.Click += new System.EventHandler(this.btnCancelAddAccounts_Click);
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            resources.ApplyResources(this.btnN, "btnN");
            this.btnN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnN.FlatAppearance.BorderSize = 0;
            this.btnN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnN.Image = global::Account_Manager.Properties.Resources.right_arrow;
            this.btnN.Name = "btnN";
            this.btnN.UseVisualStyleBackColor = false;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            resources.ApplyResources(this.btnP, "btnP");
            this.btnP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnP.FlatAppearance.BorderSize = 0;
            this.btnP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnP.Image = global::Account_Manager.Properties.Resources.left_arrow;
            this.btnP.Name = "btnP";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // grpPAccounts
            // 
            this.grpPAccounts.Controls.Add(this.btnMAccount);
            this.grpPAccounts.Controls.Add(this.btnAddAccount);
            this.grpPAccounts.Controls.Add(this.txtAPUserName);
            this.grpPAccounts.Controls.Add(this.lblAPUserName);
            this.grpPAccounts.Controls.Add(this.txtAPPassword);
            this.grpPAccounts.Controls.Add(this.txtAPEmail);
            this.grpPAccounts.Controls.Add(this.lblAPPassword);
            this.grpPAccounts.Controls.Add(this.lblAPEmail);
            resources.ApplyResources(this.grpPAccounts, "grpPAccounts");
            this.grpPAccounts.Name = "grpPAccounts";
            this.grpPAccounts.TabStop = false;
            // 
            // btnMAccount
            // 
            this.btnMAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnMAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnMAccount.BorderColor = System.Drawing.Color.Empty;
            this.btnMAccount.BorderRadius = 15;
            this.btnMAccount.BorderSize = 1;
            this.btnMAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMAccount.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMAccount, "btnMAccount");
            this.btnMAccount.ForeColor = System.Drawing.Color.White;
            this.btnMAccount.Name = "btnMAccount";
            this.btnMAccount.TextColor = System.Drawing.Color.White;
            this.btnMAccount.UseVisualStyleBackColor = false;
            this.btnMAccount.Click += new System.EventHandler(this.btnMAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAddAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAddAccount.BorderColor = System.Drawing.Color.Empty;
            this.btnAddAccount.BorderRadius = 15;
            this.btnAddAccount.BorderSize = 1;
            this.btnAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAddAccount, "btnAddAccount");
            this.btnAddAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.TextColor = System.Drawing.Color.White;
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtAPUserName
            // 
            this.txtAPUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtAPUserName, "txtAPUserName");
            this.txtAPUserName.Name = "txtAPUserName";
            // 
            // lblAPUserName
            // 
            resources.ApplyResources(this.lblAPUserName, "lblAPUserName");
            this.lblAPUserName.Name = "lblAPUserName";
            // 
            // txtAPPassword
            // 
            this.txtAPPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtAPPassword, "txtAPPassword");
            this.txtAPPassword.Name = "txtAPPassword";
            // 
            // txtAPEmail
            // 
            this.txtAPEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtAPEmail, "txtAPEmail");
            this.txtAPEmail.Name = "txtAPEmail";
            // 
            // lblAPPassword
            // 
            resources.ApplyResources(this.lblAPPassword, "lblAPPassword");
            this.lblAPPassword.Name = "lblAPPassword";
            // 
            // lblAPEmail
            // 
            resources.ApplyResources(this.lblAPEmail, "lblAPEmail");
            this.lblAPEmail.Name = "lblAPEmail";
            // 
            // lblAddAccounts
            // 
            resources.ApplyResources(this.lblAddAccounts, "lblAddAccounts");
            this.lblAddAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.lblAddAccounts.Name = "lblAddAccounts";
            // 
            // lblOutPut
            // 
            resources.ApplyResources(this.lblOutPut, "lblOutPut");
            this.lblOutPut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.lblOutPut.Name = "lblOutPut";
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
            // UserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAddAccounts);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.pnlViewAccounts);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpAccounts.ResumeLayout(false);
            this.grpAccounts.PerformLayout();
            this.pnlViewAccounts.ResumeLayout(false);
            this.grpAddPlat.ResumeLayout(false);
            this.grpAddPlat.PerformLayout();
            this.pnlAddAccounts.ResumeLayout(false);
            this.pnlAddAccounts.PerformLayout();
            this.grpPAccounts.ResumeLayout(false);
            this.grpPAccounts.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAccountManagerToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbPlatforms;
        private System.Windows.Forms.Button btnAddPlat;
        private System.Windows.Forms.GroupBox grpAccounts;
        private System.Windows.Forms.TextBox txtPPassword;
        private System.Windows.Forms.TextBox txtPEmail;
        private System.Windows.Forms.Label lblPPassword;
        private System.Windows.Forms.Label lblPEmail;
        private System.Windows.Forms.Panel pnlViewAccounts;
        private System.Windows.Forms.TextBox txtPlatName;
        private System.Windows.Forms.Label lblPlatName;
        private System.Windows.Forms.Button btnAPCancel;
        private System.Windows.Forms.Button btnAPConfirm;
        private System.Windows.Forms.Panel pnlAddAccounts;
        private System.Windows.Forms.Label lblAddAccounts;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtPUserName;
        private System.Windows.Forms.Label lblPUserName;
        private System.Windows.Forms.Button btnAddA;
        private System.Windows.Forms.GroupBox grpAddPlat;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.GroupBox grpPAccounts;
        private System.Windows.Forms.TextBox txtAPUserName;
        private System.Windows.Forms.Label lblAPUserName;
        private System.Windows.Forms.TextBox txtAPPassword;
        private System.Windows.Forms.TextBox txtAPEmail;
        private System.Windows.Forms.Label lblAPPassword;
        private System.Windows.Forms.Label lblAPEmail;
        private System.Windows.Forms.Label lblOutPut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblAccountManager;
        private System.Windows.Forms.Button btnLogo;
        private CustomControls.RJControls.RJButton btnUCancel;
        private CustomControls.RJControls.RJButton btnA;
        private CustomControls.RJControls.RJButton btnUChecked;
        private CustomControls.RJControls.RJButton btnDelete;
        private CustomControls.RJControls.RJButton btnUpdate;
        private CustomControls.RJControls.RJButton btnExit;
        private CustomControls.RJControls.RJButton btnSaveAccounts;
        private CustomControls.RJControls.RJButton btnCancelAddAccounts;
        private CustomControls.RJControls.RJButton btnMAccount;
        private CustomControls.RJControls.RJButton btnAddAccount;
    }
}