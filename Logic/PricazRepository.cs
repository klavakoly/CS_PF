using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PricazRepository : IRepository<Pricaz>
    {
        public bool Add(Pricaz obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Pricaz Get(int ID)
        {
            string query = "select People.INN as iNN, TipeOfPensy.TypePensy as pency, PricazNumber as iD, " +
                   "[starting(month)] as Smonth, [starting(year)] as Syear, Surname as sername, " +
                   "Name as name, MiddleName as middleName  from Pricaz join " +
                   "People on People.INN = Pricaz.INN join TipeOfPensy on  Pricaz.IDpensy = TipeOfPensy.IDpensy where People.INN = @INN";
            Pricaz res = null;
            using (var connection = new SqlConnection(connectionString))
            {
                res = connection.
                    Query<Pricaz>(query, new { INN = ID })
                    .First();

            }
            return res;
        }

        public IEnumerable<Pricaz> GetAll()
        {
            string query = "select People.INN as iNN, TipeOfPensy.TypePensy as pency, PricazNumber as iD, " +
                "[starting(month)] as Smonth, [starting(year)] as Syear, Surname as sername, " +
                "Name as name, MiddleName as middleName  from Pricaz join " +
                "People on People.INN = Pricaz.INN join TipeOfPensy on  Pricaz.IDpensy = TipeOfPensy.IDpensy";
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Pricaz>(query);
            }
        }

        public Pricaz[] GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Update(Pricaz obj)
        {
            throw new NotImplementedException();
        }

        private PricazRepository()
        {

        }
        private string connectionString;

        private static PricazRepository repository = new PricazRepository();

        public static void Configure(string connectionString)
        {
            repository.connectionString = connectionString;
        }

        public static PricazRepository GetRepository()
        {
            return repository;
        }

    }
}
