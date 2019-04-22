using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LgoteRepository : IRepository<Lgote>
    {
        public bool Add(Lgote obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Lgote Get(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lgote> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Lgote obj)
        {
            throw new NotImplementedException();
        }

        private LgoteRepository()
        {
        }

        private string connectionString;
        private static LgoteRepository repository = new LgoteRepository();

        public static void Configure(string connectionString)
        {
            repository.connectionString = connectionString;
        }

        public static LgoteRepository GetRepository()
        {
            return repository;
        }

        public IEnumerable<Lgote> GetLgotsForPency(int IdPency)
        {
            string query = "select NumberL as ID, NameL as name, Soderganie as information " +
            $"from LgotyForThisPensy({IdPency}) join lgoty on lgoty.NumberL = Id_lgot";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Lgote>(query);
            }
        }

        public Lgote[] GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        bool IRepository<Lgote>.Update(Lgote obj)
        {
            throw new NotImplementedException();
        }
    }
}
