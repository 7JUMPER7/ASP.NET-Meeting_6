using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_6.DAL
{
    public interface IRepository<T> where T: class, IEntity
    {
        IEnumerable<T> GetAll();
        void Create(T item);
        void Update(T item);
        bool Delete(int id);
        T GetItem(int id);
    }
}
