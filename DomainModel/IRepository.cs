using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetRecords();
        void Create(T record);
        T Read(int id);
        void Update(T record);
        void Delete(int id);

    }
}
