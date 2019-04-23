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
        public bool Add(TypePensy obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public TypePensy Get(int ID)
        {
            //string aSQL = "select TipeOfPensy.IDpensy as id, TypePensy as name from TipeOfPensy join " +
            //              "Rassmotrenie on Rassmotrenie.IDpensy = TipeOfPensy.IDpensy where INN = @INN";
            string query = "select TipeOfPensy.IDpensy as id, TypePensy as name, sizePensy as sizePency from TipeOfPensy join " +
                            "Rassmotrenie on Rassmotrenie.IDpensy = TipeOfPensy.IDpensy join " +
                            "SizePensy on SizePensy.IDpensy = Rassmotrenie.IDpensy where INN = @INN";
            TypePensy res = null;
            using (var connection = new SqlConnection(connectionString))
            {
                res = connection.
                    Query<TypePensy>(query, new { INN = ID })
                    .First();

            }
            return res;
        }

        public IEnumerable<TypePensy> GetAll()
        {
            string query = "select TipeOfPensy.IDpensy as id, TypePensy as name, SizePensy as sizePency from TipeOfPensy join "+
                           "SizePensy on SizePensy.IDpensy = TipeOfPensy.IDpensy";
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<TypePensy>(query);
            }
        }

        public int GetIdPency(string name)
        {
            string query = $"select IDpensy from TipeOfPensy where TypePensy = '{name}'";
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<int>(query).First();
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

        public TypePensy[] GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        bool IRepository<TypePensy>.Update(TypePensy obj)
        {
            throw new NotImplementedException();
        }
    }
}
