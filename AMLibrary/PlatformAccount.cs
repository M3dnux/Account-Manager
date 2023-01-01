using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMLibrary
{
    public class PlatformAccount
    {
        private string pUserName;
        private string email;
        private string password;
        private string userName;
        private string platformName;

        public PlatformAccount(string pUserName, string email, string password, string userName, string platformName)
        {
            this.pUserName = pUserName;
            this.email = email;
            this.password = password;
            this.userName = userName;
            this.platformName = platformName;
        }

        public string PUserName { get => pUserName; set => pUserName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PlatformName { get => platformName; set => platformName = value; }

        public override string ToString()
        {
            return pUserName+" | "+email+" | "+password+" | "+userName+" | "+platformName;
        }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                PlatformAccount platformAccount = (PlatformAccount)obj;
                if (platformAccount.pUserName != "" && this.PUserName.Equals(platformAccount.pUserName) || this.Email.Equals(platformAccount.Email)) return true;
                else return false;
            }
            return false;
        }
    }
}