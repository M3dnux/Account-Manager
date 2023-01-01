using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMLibrary
{
    public class SqliteDataAccess
    {
        public static List<Account> LoadAccounts()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Account>("SELECT * FROM ACCOUNT", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveAccount(Account account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO ACCOUNT (UserName, Password, FirstName, LastName, Email) VALUES (@userName, @password, @firstName, @lastName, @email)", account);
            }
        }

        public static List<Platform> LoadPlatforms(string userName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Platform>("SELECT * FROM PLATFORM WHERE UserName = '"+userName+"'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePlatform(Platform platform)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO PLATFORM (PlatformName, UserName) VALUES (@platformName, @userName)", platform);
            }
        }

        public static List<PlatformAccount> LoadPlatformAccounts(Platform platform)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PlatformAccount>("SELECT * FROM PLATFORMACCOUNT WHERE UserName = '" + platform.UserName + "' AND PlatformName = '" + platform.PlatformName + "'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePlatformAccount(PlatformAccount platformAccount)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO PLATFORMACCOUNT (PUserName, Email, Password, UserName, PlatformName) VALUES (@pUserName, @email, @password, @userName, @platformName)", platformAccount);
            }
        }

        public static void UpdatePlatformAccount(PlatformAccount newPlatformAccount, PlatformAccount oldPlatformAccount)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE PLATFORMACCOUNT SET PUserName = '" + newPlatformAccount.PUserName + "' , Email = '" + newPlatformAccount.Email + "' , Password = '" + newPlatformAccount.Password + "' WHERE Email = '" + oldPlatformAccount.Email + "' AND Password = '" + oldPlatformAccount.Password + "' AND UserName = '" + oldPlatformAccount.UserName + "' AND PlatformName = '" + oldPlatformAccount.PlatformName + "'");
            }
        }

        public static void DeletePlatformAccount(PlatformAccount platformAccount)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM PLATFORMACCOUNT WHERE Email = '" + platformAccount.Email + "' AND Password = '" + platformAccount.Password + "' AND UserName = '" + platformAccount.UserName + "' AND PlatformName = '" + platformAccount.PlatformName+ "'", platformAccount);

                var count = cnn.ExecuteScalar<int>("SELECT COUNT(*) FROM PLATFORMACCOUNT WHERE PlatformName = '" + platformAccount.PlatformName + "'");

                if (count == 0) cnn.Execute("DELETE FROM PLATFORM WHERE PlatformName = '" + platformAccount.PlatformName + "' AND UserName = '" + platformAccount.UserName + "'");
            }
        }

        public static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
    }
}