using System.Collections.Generic;
using _4Events.Model;
using _4Events.Database;
using System.IO;
using System;
using System.Security.Principal;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _4Events.Logic
{
    public class Beheer
    {
        private IBeheerRepository repository = new BeheerContext();
        private string path = "CurrentAccount";

        public Beheer(IBeheerRepository repository)
        {
            this.repository = repository;
        }

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

        public Event InsertEvent(Event Event)
        {
            return repository.InsertEvent(Event);
        }

        public int GetAccountCache()
        {
            IFormatter formatter = new BinaryFormatter();
            try
            {
                using (Stream s = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    Account account = (Account)formatter.Deserialize(s);
                    return account.ID;
                }
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (SerializationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool CreateAccountCache(Account account)
        {
            IFormatter formatter = new BinaryFormatter();
            try
            {
                using (Stream s = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(s, account);
                }
            }
            //catch (ArgumentNullException)
            //{ }
            //catch (SerializationException)
            //{ }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        // Kan nog een salt toevoegen voor ultieme beveiliging.
        private string EncryptPassword(string inputString)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(inputString);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }
    }
}
