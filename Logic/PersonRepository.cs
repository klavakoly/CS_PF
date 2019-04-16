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
            string date = $"{obj.DataRogdeniya.Year}.{obj.DataRogdeniya.Month}.{obj.DataRogdeniya.Day}";
            string query = "INSERT INTO People(INN, Surname, Name, MiddleName, RegistrationCity, ContactPhone, DataaRogdeniya)" +
            $" VALUES ({obj.INN},'{obj.Surname}', '{obj.Name}','{obj.MiddleName}', '{obj.Surname}', '{obj.ContactPhone}', '{date}')";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Query(query);
                }
            }catch(Exception e)
            {
                //ToDo
            }
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
                    Query<Person>(aSQL, new { INN = ID })
                    .First();

            }
            return res;
        }

        public void Update(Person obj)
        {
            throw new NotImplementedException();
        }

        private string connectionString;

        private PersonRepository( )
        {

        }

        private static PersonRepository repository = new PersonRepository();

        public static void Configure(string connectionString)
        {
            repository.connectionString = connectionString;
        }

        public static PersonRepository GetRepository()
        {
            return repository;
        }

        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
