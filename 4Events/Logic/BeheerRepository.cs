using System.Collections.Generic;
using _4Events.Model;
using _4Events.Database;
using System.IO;
using System;
using System.Security.Principal;

namespace _4Events.Logic
{
    public class BeheerRepository
    {
        private IBeheerContext context;

        public BeheerRepository(IBeheerContext context)
        {
            this.context = context;
        }

        public List<Account> GetAllAccounts()
        {
            return context.GetAllAccounts();
        }

        public Account GetAccountById(int id)
        {
            return context.GetAccountById(id);
        }

        public Account GetAccountByEmail(string email)
        {
            return context.GetAccountByEmail(email);
        }

        public Account InsertAccount(Account account)
        {
            return context.InsertAccount(account);
        }

        public bool DeleteAccount(int id)
        {
            return context.DeleteAccount(id);
        }

        public bool UpdateAccount(Account newItem)
        {
            return context.UpdateAccount(newItem);
        }

        public List<Event> GetAllEvents()
        {
            return context.GetAllEvents();
        }

        public Event InsertEvent(Event newItem)
        {
            return context.InsertEvent(newItem);
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
