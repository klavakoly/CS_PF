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
        void Update(T obj);
        void Add(T obj);
        T Get(int ID);
    }
}


