﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModels;
namespace Register
{
    public class SqliteDataAccess
    {
        public static List<AccountItemModel> LoadAccountItems(AccountModel account) 
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AccountItemModel>($"select * from AccountItems where AccountId=='{account.Id}'", new DynamicParameters()).ToList();
                return output;
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
