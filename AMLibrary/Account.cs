using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMLibrary
{
    public class Account
    {
        private string userName;
        private string password;
        private string firstName;
        private string lastName;
        private string email;

        public Account(string userName, string password, string firstName, string lastName, string email)
        {
            this.userName = userName;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        public Account(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return "[ " + firstName + " | " + lastName + " | " + email + " | " + userName + " | " + password + " ]";
        }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Account account = (Account)obj;
                if (this.userName.Equals(account.userName)) return true;
                else return false;
            }
            return false;
        }
    }
}