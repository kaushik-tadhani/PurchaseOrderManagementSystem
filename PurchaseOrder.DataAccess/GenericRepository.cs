using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.DataAccess
{
    public class GenericRepository<T> : IGenericRepository<T>
    {
        private readonly IDbConnectionFactory _connectionFactory;
        private readonly string _tableName;

        public GenericRepository(IDbConnectionFactory connectionFactory, string tableName)
        {
            _connectionFactory = connectionFactory;
            _tableName = tableName;
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Search(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
