using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMLibrary;

namespace Account_Manager
{
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
        }

        // ********** pnlLogIn **********

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShowHide.Image = Properties.Resources.hide;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShowHide.Image = Properties.Resources.show;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            List<Account> listAccounts = SqliteDataAccess.LoadAccounts();
            bool found = false;
            if (txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "") MessageBox.Show("Both Username / Password fields must be filled.");
            else
            {
                foreach (Account account in listAccounts)
                {
                    if (txtUserName.Text.Equals(account.UserName))
                    {
                        found = true;
                        if (txtPassword.Text.Equals(account.Password))
                        {
                            this.Hide();
                            UserForm userForm = new UserForm(txtUserName.Text, txtPassword.Text);
                            userForm.ShowDialog();
                            this.Close();
                        }
                        else MessageBox.Show("Wrong password.");
                    }
                }
                if (found == false) MessageBox.Show("There is no account with this Username.");
            }
        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clearLogIn();
            clearSignUpForm();
            lblOutPut.Text = "";
            pnlSignUp.Visible = true;
            pnlLogIn.Visible = false;
        }

        private void clearLogIn()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        // ******************************

        // ********** pnlSignUp **********

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Account> listAccounts = SqliteDataAccess.LoadAccounts();
            bool found = false;

            string userName = txtNUserName.Text.Trim();
            string nPassword = txtNPassword.Text.Trim();
            string rePassword = txtRePassword.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (firstName == "" && lastName == "" && email == "" && userName == "" && nPassword == "" && rePassword == "") MessageBox.Show("You must at least fill the Username / Password fields.");

            else if (userName != "" && nPassword != "" && rePassword != "" && nPassword == rePassword)
            {
                Account account;
                if (firstName != "" && lastName != "" && email != "" && userName != "")
                {
                    account = new Account(userName, rePassword, firstName, lastName, email);
                    foreach (Account a in listAccounts)
                    {
                        if (a.Equals(account))
                        {
                            MessageBox.Show("Username not available.");
                            found = true;
                        }
                    }
                }
                else
                {
                    account = new Account(userName, rePassword);
                    foreach (Account a in listAccounts)
                    {
                        if (a.Equals(account))
                        {
                            MessageBox.Show("Username not available.");
                            found = true;
                        }
                    }
                }
                if (!found)
                {
                    SqliteDataAccess.SaveAccount(account);
                    pnlSignUp.Visible = false;
                    pnlLogIn.Visible = true;
                    lblOutPut.Location = new Point(348, 33);
                    lblOutPut.Text = "( Account successfully created. )";
                }
            }
            else if (userName == "" && nPassword == "" && rePassword == "") MessageBox.Show("You must fill the Username / Password fields.");
            else if (rePassword == "" && nPassword != "") MessageBox.Show("Re-Enter The Password.");
            else if (nPassword != "" && rePassword == "" || rePassword != "" && nPassword == "") MessageBox.Show("Enter a Password.");
            else if (userName == "") MessageBox.Show("Enter a Username.");
            else if (nPassword == "") MessageBox.Show("Enter a Password.");
            else MessageBox.Show("Password does not match.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblOutPut.Location = new Point(357, 33);
            lblOutPut.Text = "( Account Creation canceled. )";
            pnlLogIn.Visible = true;
            pnlSignUp.Visible = false;
            clearSignUpForm();
        }

        private void clearSignUpForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtNUserName.Text = "";
            txtNPassword.Text = "";
            txtRePassword.Text = "";
        }

        // *******************************

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