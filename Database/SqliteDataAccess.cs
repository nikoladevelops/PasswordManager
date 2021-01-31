using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace DatabaseModels
{
    public class SqliteDataAccess
    {
        public static void DeleteAccountItem (int accountItemId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"delete from AccountItems Where Id=={accountItemId}");
            }
        }
        public static AccountItemModel LoadMostRecentAccountItem(AccountModel account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AccountItemModel>($"SELECT * FROM AccountItems WHERE AccountId =={account.Id} ORDER BY Id DESC LIMIT 1;", new DynamicParameters()).ToList().FirstOrDefault();
                return output;
            }
        }

        public static List<AccountItemModel> LoadAllAccountItems(AccountModel account) 
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AccountItemModel>($"select * from AccountItems where AccountId=={account.Id}", new DynamicParameters()).ToList();
                return output;
            }
        }

        public static void SaveAccountItem(AccountItemModel accountItems)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // TODO check if account already exists!
                cnn.Execute("insert into AccountItems (Image,ImagePassword,AccountId) values (@Image,@ImagePassword,@AccountId)", accountItems);
            }
        }

        public static AccountModel LoadAccount (string username, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var account = cnn.Query<AccountModel>($"select * from Accounts WHERE Username=='{username}'", new DynamicParameters()).ToList().FirstOrDefault();
                

                try
                {
                    var decryptedEmail = StringCipher.Decrypt(account.Email, password);
                    var decryptedPassword = StringCipher.Decrypt(account.Password, password);
                }
                catch (Exception)
                {
                    throw new ArgumentException("Invalid Username or Password");
                }
                return account;
                
            }
        }

        public static void SaveAccount(AccountModel account) 
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
              // TODO check if account already exists!
                cnn.Execute("insert into Accounts (Username,Email,Password) values (@Username,@Email,@Password)", account);
            }
        }

        private static string LoadConnectionString(string id = "Default") 
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
