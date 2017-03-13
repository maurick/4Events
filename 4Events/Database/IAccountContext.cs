using System.Collections.Generic;

namespace _4Events.Database
{
    public interface IAccountContext<Account>
    {
        List<Account> GetAll();
        Account GetById(int id);
        Account GetByUsername(string username);
        Account Insert(Account newItem);
        bool Update(Account newItem);
        bool Delete(int id);
    }
}