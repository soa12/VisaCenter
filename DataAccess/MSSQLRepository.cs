using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MSSQLRepository<T> : IRepository<T>
    {
        private MSSQLContext context;// = new MSSQLContext();

        public MSSQLRepository(string connectionString = "SQLServer")
        {
            context = new MSSQLContext(connectionString);

        }

        public void Create(T record)
        {
            //context.Employees.Add(record);
            //context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetRecords()
        {
            throw new NotImplementedException();
        }

        public T Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T record)
        {
            throw new NotImplementedException();
        }
    }
}
