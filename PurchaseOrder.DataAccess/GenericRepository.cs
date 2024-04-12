using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public GenericRepository(string tableName)
        {
            _connectionFactory = new SqlConnectionFactory("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\PrateekDrive\\High Quality Software programming\\project final\\PurchaseOrderManagementSystem\\DataBase\\PurchaseOrderManagementSystem.mdf\";Integrated Security=True");
            _tableName = tableName;
        }

        public void Insert(T entity)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                connection.Open();
                var properties = typeof(T).GetProperties().Where(p => !p.Name.Contains("Id"));
                var columns = string.Join(", ", properties.Select(p => p.Name));
                var values = string.Join(", ", properties.Select(p => $"@{p.Name}"));
                var commandText = $"INSERT INTO {_tableName} ({columns}) VALUES ({values})";
                var command = new SqlCommand(commandText, connection);
                foreach (var property in properties)
                {
                    command.Parameters.AddWithValue($"@{property.Name}", property.GetValue(entity));
                }
                command.ExecuteNonQuery();
            }
        }

        public void Update(T entity)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                connection.Open();
                var properties = typeof(T).GetProperties().Where(p => !p.Name.Contains("Id"));
                var columns = string.Join(", ", properties.Select(p => $"{p.Name} = @{p.Name}"));
                var commandText = $"UPDATE {_tableName} SET {columns} WHERE Id = @Id";
                var command = new SqlCommand(commandText, connection);
                foreach (var property in properties)
                {
                    command.Parameters.AddWithValue($"@{property.Name}", property.GetValue(entity));
                }
                command.Parameters.AddWithValue("@Id", typeof(T).GetProperty("Id").GetValue(entity));
                command.ExecuteNonQuery();
            }
        }

        public void Delete(T entity)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                connection.Open();
                var commandText = $"DELETE FROM {_tableName} WHERE Id = @Id";
                var command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@Id", typeof(T).GetProperty("Id").GetValue(entity));
                command.ExecuteNonQuery();
            }
        }

        public T GetById(int id)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                connection.Open();
                var commandText = $"SELECT * FROM {_tableName} WHERE Id = @Id";
                var command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@Id", id);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var entity = Activator.CreateInstance<T>();
                    foreach (var property in typeof(T).GetProperties())
                    {
                        property.SetValue(entity, Convert.ChangeType(reader[property.Name], property.PropertyType));
                    }
                    return entity;
                }
                return default(T);
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                connection.Open();
                var commandText = $"SELECT * FROM {_tableName}";
                var command = new SqlCommand(commandText, connection);
                var reader = command.ExecuteReader();
                var entities = new List<T>();
                while (reader.Read())
                {
                    var entity = Activator.CreateInstance<T>();
                    foreach (var property in typeof(T).GetProperties())
                    {
                        property.SetValue(entity, Convert.ChangeType(reader[property.Name], property.PropertyType));
                    }
                    entities.Add(entity);
                }
                return entities;
            }
        }

        public IEnumerable<T> Search(Expression<Func<T, bool>> predicate)
        {
            var entities = GetAll();
            return entities.AsQueryable().Where(predicate.Compile());
        }
    }
}
