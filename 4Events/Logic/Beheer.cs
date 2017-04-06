using System.Collections.Generic;
using _4Events.Model;
using _4Events.Database;
using System.IO;
using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _4Events.Logic
{
    /// <summary>
    /// Het beheersysteem.
    /// </summary>
    public class Beheer
    {
        private IBeheerRepository repository = new BeheerContext();
        private string path = "CurrentAccount";

        public Beheer(IBeheerRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Checkt of het emailadress en wachtwoord overeen komt.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        public bool InsertRFID(int AccountID, string rfid)
        {
            return repository.InsertRFIDAccount(AccountID, rfid);
        }

        /// <summary>
        /// Checkt welk account is ingelogd.
        /// </summary>
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
            catch (ArgumentNullException) // Laat in deze drie exceptions wat nuttigs gebeuren.
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

        /// <summary>
        /// Maakt een bestand aan op de computer om het account te authentificeren.
        /// </summary>
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

        private string EncryptPassword(string inputString) // Kan nog een salt toevoegen voor ultieme beveiliging.
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(inputString);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }
    }
}
