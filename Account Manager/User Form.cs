using AMLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Manager
{
    public partial class UserForm : Form
    {
        private string userName;
        private string password;

        public UserForm(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            cmbPlatforms.Enabled = true;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            grpAddPlat.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnA.Visible = false;
            
            txtPUserName.Text = "";
            txtPEmail.Text = "";
            txtPPassword.Text = "";
            grpAccounts.Text = "...";
            cmbPlatforms.Text = "";
            cmbPlatforms.Items.Clear();
            cmbPlatforms.SelectedIndex = -1;
            List<Platform> platforms = SqliteDataAccess.LoadPlatforms(userName);
            cmbPlatforms.Items.AddRange(platforms.ToArray());

            // Auto Complete cmbPlatforms.Text
            cmbPlatforms.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            string[] platList = new string[platforms.Count];
            for(int i = 0; i < platforms.Count; i++) platList[i] = platforms[i].PlatformName;
            cmbPlatforms.AutoCompleteCustomSource.AddRange(platList);
            cmbPlatforms.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPlatforms.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // ********** pnlViewAccounts **********

        List<PlatformAccount> platformAccounts;
        Platform selectedPlatform;
        private int nav;

        private void cmbPlatforms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlatforms.SelectedIndex != -1)
            {
                nav = 1;
                lblOutPut.Text = "";
                grpAccounts.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAddA.Visible = true;
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                
                selectedPlatform = (Platform)cmbPlatforms.SelectedItem;
                platformAccounts = SqliteDataAccess.LoadPlatformAccounts(selectedPlatform);
                grpAccounts.Text = "Account 1";
                txtPUserName.Text = platformAccounts.First().PUserName;
                txtPEmail.Text = platformAccounts.First().Email;
                txtPPassword.Text = platformAccounts.First().Password;
                if (platformAccounts.Count() > 1) btnNext.Enabled = true;
            }
        }

        private void btnAddPlat_Click(object sender, EventArgs e)
        {
            lblOutPut.Text = "";
            txtPlatName.Text = "";
            grpAddPlat.Visible = true;
            cmbPlatforms.Enabled = false;
            grpAccounts.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddPlat.Enabled = false;
        }

        private void btnAPConfirm_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (txtPlatName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a Platform Name.");
                txtPlatName.Text = "";
            }
            else
            {
                List<Platform> platforms = SqliteDataAccess.LoadPlatforms(userName);
                foreach (Platform platform in platforms)
                {
                    if (platform.PlatformName.ToLower().Equals(txtPlatName.Text.ToLower()))
                    {
                        MessageBox.Show("This Platform already exists.");
                        found = true;
                    }
                }
                if (!found)
                {
                    btnAddPlat.Enabled = true;
                    pnlAddAccounts.Visible = true;
                    btnAddAccount.Enabled = true;
                    pnlViewAccounts.Visible = false;
                    btnMAccount.Enabled = false;
                }
            }
        }

        private void btnAPCancel_Click(object sender, EventArgs e)
        {
            btnAddPlat.Enabled = true;
            pnlViewAccounts.Visible = true;
            cmbPlatforms.Enabled = true;
            grpAccounts.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            grpAddPlat.Visible = false;
            if (nav == 1) btnPrevious.Enabled = false;
            UserForm_Load(sender, e);
            lblOutPut.Location = new Point(337, 33);
            lblOutPut.Text = "( Adding a Platform is canceled. )";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            nav--;
            btnNext.Enabled = true;
            grpAccounts.Text = "Account " + nav;
            PlatformAccount platformAccount = platformAccounts.ElementAt(nav - 1);
            txtPUserName.Text = platformAccount.PUserName;
            txtPEmail.Text = platformAccount.Email;
            txtPPassword.Text = platformAccount.Password;
            if (nav == 1) btnPrevious.Enabled = false;
            if (nav == platformAccounts.Count()) btnNext.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nav++;
            btnPrevious.Enabled = true;
            grpAccounts.Text = "Account " + nav;
            PlatformAccount platformAccount = platformAccounts.ElementAt(nav - 1);
            txtPUserName.Text = platformAccount.PUserName;
            txtPEmail.Text = platformAccount.Email;
            txtPPassword.Text = platformAccount.Password;
            if (nav == platformAccounts.Count()) btnNext.Enabled = false;
        }

        private void btnAddA_Click(object sender, EventArgs e)
        {
            btnA.Visible = true;
            btnAddA.Visible = false;      
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            txtPUserName.ReadOnly = false;
            txtPEmail.ReadOnly = false;
            txtPPassword.ReadOnly = false;
            grpAccounts.Text = "Adding an Account";
            txtPUserName.Text = "";
            txtPEmail.Text = "";
            txtPPassword.Text = "";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (txtPEmail.Text.Trim() == "" || txtPPassword.Text.Trim() == "")
            {
                MessageBox.Show("Both Email / Password fields must not be empty.");
                if (txtPEmail.Text.Trim() == "") txtPEmail.Text = "";
                if (txtPPassword.Text.Trim() == "") txtPPassword.Text = "";
            }
            else
            {
                bool found = false;
                PlatformAccount platformAccount = new PlatformAccount(txtPUserName.Text, txtPEmail.Text, txtPPassword.Text, userName, selectedPlatform.PlatformName);

                foreach (PlatformAccount pA in platformAccounts)
                {
                    if (pA.Equals(platformAccount)) found = true;
                }
                if (!found)
                {
                    SqliteDataAccess.SavePlatformAccount(platformAccount);
                    UserForm_Load(sender, e);
                }
                else MessageBox.Show("You can not have 2 accounts with the same Username or Email.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUChecked.Visible = true;
            btnUCancel.Visible = true;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            txtPUserName.ReadOnly = false;
            txtPEmail.ReadOnly = false;
            txtPPassword.ReadOnly = false;
        }

        private void btnUChecked_Click(object sender, EventArgs e)
        {
            if (txtPEmail.Text.Trim() == "" || txtPPassword.Text.Trim() == "")
            {
                MessageBox.Show("Both Email / Password fields must not be empty.");
                if (txtPEmail.Text.Trim() == "") txtPEmail.Text = "";
                if (txtPPassword.Text.Trim() == "") txtPPassword.Text = "";
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to perform this task ?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PlatformAccount oldPlatformAccount = platformAccounts.ElementAt(nav - 1);
                    PlatformAccount newPlatformAccount = new PlatformAccount(txtPUserName.Text, txtPEmail.Text, txtPPassword.Text, userName, txtPlatName.Text);

                    SqliteDataAccess.UpdatePlatformAccount(newPlatformAccount, oldPlatformAccount);
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;
                    txtPUserName.ReadOnly = true;
                    txtPEmail.ReadOnly = true;
                    txtPPassword.ReadOnly = true;
                    btnUChecked.Visible = false;
                    btnUCancel.Visible = false;
                    if (nav == 1) btnPrevious.Enabled = false;
                    if (nav == platformAccounts.Count()) btnNext.Enabled = false;
                    lblOutPut.Location = new Point(328, 33);
                    UserForm_Load(sender, e);
                    lblOutPut.Text = "( Account was successfully updated. )";
                }
            }
        }

        private void btnUCancel_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            txtPUserName.ReadOnly = true;
            txtPEmail.ReadOnly = true;
            txtPPassword.ReadOnly = true;
            btnUChecked.Visible = false;
            btnUCancel.Visible = false;  
            PlatformAccount oldPlatformAccount = platformAccounts.ElementAt(nav - 1);
            txtPUserName.Text = oldPlatformAccount.PUserName;
            txtPEmail.Text = oldPlatformAccount.Email;
            txtPPassword.Text = oldPlatformAccount.Password;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to perform this task ?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PlatformAccount platformAccount = platformAccounts.ElementAt(nav - 1);
                SqliteDataAccess.DeletePlatformAccount(platformAccount);
                UserForm_Load(sender, e);
            }
        }

        // *************************************

        // ********** pnlAddAccounts **********

        private int numberAccounts = 1;
        private int counter = 1;

        List<PlatformAccount> platAccounts = new List<PlatformAccount>();

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (txtAPEmail.Text.Trim() == "" || txtAPPassword.Text.Trim() == "")
            {
                MessageBox.Show("Both Email / Password fields must not be empty.");
                if (txtAPEmail.Text.Trim() == "") txtAPEmail.Text = "";
                if (txtAPPassword.Text.Trim() == "") txtAPPassword.Text = "";
            }
            else
            {
                bool found = false;
                PlatformAccount platformAccount = new PlatformAccount(txtAPUserName.Text, txtAPEmail.Text, txtAPPassword.Text, userName, txtPlatName.Text);

                foreach(PlatformAccount pA in platAccounts)
                {
                    if(pA.Equals(platformAccount)) found = true;
                }
                if (!found)
                {
                    int n = numberAccounts + 1;
                    grpPAccounts.Text = "Account " + n;
                    numberAccounts++;
                    counter++;
                    platAccounts.Add(platformAccount);
                    ClearAddAccountsTexts();
                    btnP.Enabled = true;
                }
                else MessageBox.Show("You can not have 2 accounts with the same Username or Email.");
            }
        }

        private void btnSaveAccounts_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to perform this task ?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (numberAccounts >= 2)
                {
                    Platform platform = new Platform(txtPlatName.Text, userName);
                    SqliteDataAccess.SavePlatform(platform);
                    MessageBox.Show("Platform : " + txtPlatName.Text + " was successfully created.");

                    foreach (PlatformAccount platA in platAccounts)
                    {
                        SqliteDataAccess.SavePlatformAccount(platA);
                    }
                    ClearAddAccounts();
                    btnP.Enabled = false;
                    btnN.Enabled = false;
                    UserForm_Load(sender, e);
                }
            }
        }

        private void btnCancelAddAccounts_Click(object sender, EventArgs e)
        {
            btnAddAccount.Enabled = true;
            ClearAddAccounts();
            UserForm_Load(sender, e);
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            counter--;
            btnN.Enabled = true;
            btnMAccount.Enabled = true;
            grpPAccounts.Text = "Account " + counter;
            PlatformAccount platA = platAccounts.ElementAt(counter - 1);
            txtAPUserName.Text = platA.PUserName;
            txtAPEmail.Text = platA.Email;
            txtAPPassword.Text = platA.Password;  
            btnAddAccount.Enabled = false;
            if (counter == 1) btnP.Enabled = false;
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter <= numberAccounts -1)
            {
                grpPAccounts.Text = "Account " + counter;
                PlatformAccount platA = platAccounts.ElementAt(counter - 1);
                txtAPUserName.Text = platA.PUserName;
                txtAPEmail.Text = platA.Email;
                txtAPPassword.Text = platA.Password;
                btnMAccount.Enabled = true;
                btnP.Enabled = true;
                btnAddAccount.Enabled = false;
            }
            else
            {
                grpPAccounts.Text = "Account " + counter;
                btnP.Enabled = true;
                btnAddAccount.Enabled = true;
                btnMAccount.Enabled = false;
                btnN.Enabled = false;
                ClearAddAccountsTexts();
            }
        }

        private void btnMAccount_Click(object sender, EventArgs e)
        {
            if (txtAPEmail.Text.Trim() == "" || txtAPPassword.Text.Trim() == "")
            {
                MessageBox.Show("Both Email / Password fields must not be empty.");
                if (txtAPEmail.Text.Trim() == "") txtAPEmail.Text = "";
                if (txtAPPassword.Text.Trim() == "") txtAPPassword.Text = "";
            }
            else
            {
                if (txtAPUserName.Text.Trim() == "")
                {
                    platAccounts.ElementAt(counter - 1).Email = txtAPEmail.Text;
                    platAccounts.ElementAt(counter - 1).Password = txtAPPassword.Text;
                }
                else
                {
                    platAccounts.ElementAt(counter - 1).PUserName = txtAPUserName.Text;
                    platAccounts.ElementAt(counter - 1).Email = txtAPEmail.Text;
                    platAccounts.ElementAt(counter - 1).Password = txtAPPassword.Text;
                }
                MessageBox.Show("Account : " + counter + " was successfully updated.");
            }  
        }

        private void ClearAddAccounts()
        {
            ClearAddAccountsTexts();
            numberAccounts = 1;
            counter = 1;
            grpPAccounts.Text = "Account 1";
            platAccounts.Clear();
            pnlAddAccounts.Visible = false;
            btnP.Enabled = false;
            btnN.Enabled = false;
            pnlViewAccounts.Visible = true;
        }

        private void ClearAddAccountsTexts()
        {
            txtAPUserName.Text = "";
            txtAPEmail.Text = "";
            txtAPPassword.Text = "";
        }

        // ************************************

        private void aboutAccountManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account Manager 2022 - Current Version 1.0\n© 2022 Account Manager\nAll rights reserved.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }
    }
}