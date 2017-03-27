using System.Collections.Generic;
using _4Events.Model;

namespace _4Events.Database
{
    public interface IBeheerContext
    {
        List<Account> GetAllAccounts();
        List<Event> GetAllEvents();
        Account GetAccountById(int id);
        Account GetAccountByEmail(string email);
        List<Account> GetPresentAccountsByEventID(int EventID);
        Event GetEventById(int id);
        Account InsertAccount(Account newItem);
        Event InsertEvent(Event newItem);
        bool UpdateAccount(Account newItem);
        bool UpdateEvent(Event newItem);
        bool DeleteAccount(int id);
        bool DeleteEvent(int id);
    }
}