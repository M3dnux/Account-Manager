using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMLibrary
{
    public class Platform
    {
        private string platformName;
        private string userName;

        public Platform(string platformName, string userName)
        {
            this.platformName = platformName;
            this.userName = userName;
        }

        public string PlatformName { get => platformName; set => platformName = value; }
        public string UserName { get => userName; set => userName = value; }

        public override string ToString()
        {
            return platformName;
        }
    }
}