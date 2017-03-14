using System.Collections.Generic;
using _4Events.Model;
using _4Events.Database;
using System.IO;
using System;

namespace _4Events.Logic
{
    public class AccountRepository
    {
        private IAccountContext<Account> context;

        public AccountRepository(IAccountContext<Account> context)
        {
            this.context = context;
        }

        public List<Account> GetAll()
        {
            return context.GetAll();
        }

        public Account GetById(int id)
        {
            return context.GetById(id);
        }

        public Account GetByEmail(string email)
        {
            return context.GetByEmail(email);
        }

        public Account Insert(Account account)
        {
            return context.Insert(account);
        }

        // Waar meot dit
        private string path = "CurrentAccount";
        public void CreateAccountCache(Account account)
        {
            File.WriteAllText(path, account.ID + "");
        }

        public int GetAccountCache()
        {
            return Convert.ToInt32(File.ReadAllText(path));
        }
    }
}
