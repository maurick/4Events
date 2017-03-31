using System.Collections.Generic;
using _4Events.Model;
using _4Events.Database;
using System.IO;
using System;
using System.Security.Principal;

namespace _4Events.Logic
{
    public class Beheer
    {
        private IBeheerRepository repository = new BeheerContext();
        private string path = "CurrentAccount";

        public Account Login(string email, string password)
        {
            Account account = GetAccountByEmail(email);

            if (account.Email == email && account.Password == EncryptPassword(password))
            {
                return account;
            }

            return null;
        }

        public List<Account> GetAllAccounts()
        {
            return repository.GetAllAccounts();
        }

        public Account GetAccountById(int id)
        {
            return repository.GetAccountById(id);
        }

        public Account GetAccountByEmail(string email)
        {
            return repository.GetAccountByEmail(email);
        }

        public List<Account> GetPresentAccountsByEventID(int EventID)
        {
            return repository.GetPresentAccountsByEventID(EventID);
        }

        public Account InsertAccount(Account account)
        {
            account.Password = EncryptPassword(account.Password);
            return repository.InsertAccount(account);
        }

        public bool DeleteAccount(int id)
        {
            return repository.DeleteAccount(id);
        }

        public bool UpdateAccount(Account account)
        {
            return repository.UpdateAccount(account);
        }

        public List<Event> GetAllEvents()
        {
            return repository.GetAllEvents();
        }

        public Event InsertEvent(Event newItem)
        {
            return repository.InsertEvent(newItem);
        }

        public int GetAccountCache()
        {
            return Convert.ToInt32(File.ReadAllText(path));
        }

        public void CreateAccountCache(Account account)
        {
            File.WriteAllText(path, account.ID + "");
        }

        private string EncryptPassword(string inputString)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(inputString);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }
    }
}
