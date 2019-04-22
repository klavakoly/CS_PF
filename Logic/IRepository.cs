using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IRepository<T>
    {
        void Delete(int ID);
        bool Update(T obj);
        bool Add(T obj);
        T Get(int ID);
        T[] GetByID(int ID);
        IEnumerable<T> GetAll();
    }
}


