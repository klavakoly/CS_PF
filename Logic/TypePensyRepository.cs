using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logic
{
    public class TypePensyRepository : IRepository<TypePensy>
    {
        public void Add(TypePensy obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public TypePensy Get(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TypePensy> GetAll()
        {
            string query = "select IDpensy as id, TypePensy as name from TipeOfPensy";
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<TypePensy>(query);
            }
        }

        public void Update(TypePensy obj)
        {
            throw new NotImplementedException();
        }

        private TypePensyRepository()
        {
        }

        private string connectionString;
        private static TypePensyRepository repository = new TypePensyRepository();

        public static void Configure(string connectionString)
        {
            repository.connectionString = connectionString;
        }

        public static TypePensyRepository GetRepository()
        {
            return repository;
        }
    }
}
