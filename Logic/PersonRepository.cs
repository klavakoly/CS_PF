using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PersonRepository : IRepository<Person>
    {
        public void Add(Person obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Person Get(int ID)
        {
            string aSQL = "select * from People where INN = @INN";
            Person res = null;
            using (var connection = new SqlConnection(connectionString))
            {
                res = connection.
                    Query<Person>(aSQL,new { INN = ID})
                    .First();

            }
            return res;
        }

        public void Update(Person obj)
        {
            throw new NotImplementedException();
        }

        private string connectionString;

        public PersonRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
