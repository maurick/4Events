using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Events.Database
{
    public interface IGenericContext<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        bool Update(T newItem);
        bool Insert(T newItem);
    }
}
