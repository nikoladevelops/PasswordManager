using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public class SqliteDataAccess
    {
        public static List<AccountItemsModel> LoadAccountItems(AccountModel account) 
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AccountItemsModel>($"select * from AccountItems where AccountId == {account.Id}", new DynamicParameters());
                return output.ToList();
            }
        }
        public static AccountModel LoadAccount (string email, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var accounts = cnn.Query<AccountModel>($"select * from Accounts", new DynamicParameters())
                    .ToList();

               
                foreach (var account in accounts)
                {
                    try
                    {
                        var decryptedEmail = StringCipher.Decrypt(account.Email, email);
                        var decryptedPassword = StringCipher.Decrypt(account.Password, password);
                        return account;
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                return null;
            }
        }

        public static void SaveAccount(AccountModel account) 
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
              
                cnn.Execute("insert into Accounts (Email, Password) values (@Email, @Password)", account);
            }
        }

        private static string LoadConnectionString(string id = "Default") 
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
