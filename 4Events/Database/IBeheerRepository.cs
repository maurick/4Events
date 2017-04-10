using System.Collections.Generic;
using _4Events.Model;

namespace _4Events.Database
{
    public interface IBeheerRepository
    {
        // Get
        List<Account> GetAllAccounts();
        List<Event> GetAllEvents();
        Account GetAccountById(int id);
        Account GetAccountByEmail(string email);
        Account GetAccountByRFID(string RFID);
        List<Account> GetPresentAccountsByEventID(int EventID);
        Event GetEventById(int id);
        // Insert
        Account InsertAccount(Account newItem);
        Event InsertEvent(Event newItem);
        bool InsertRFIDAccount(int AccountID, string RFID);
        // Update
        bool UpdateAccount(Account newItem);
        bool UpdateEvent(Event newItem);
        // Delete
        bool DeleteAccount(int id);
        bool DeleteEvent(int id);
    }
}