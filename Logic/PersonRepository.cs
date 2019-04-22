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

        public bool Add(Person obj)
        {
            string date = $"{obj.DataRogdeniya.Year}.{obj.DataRogdeniya.Month}.{obj.DataRogdeniya.Day}";
            //string query = "INSERT INTO People(INN, Surname, Name, MiddleName, RegistrationCity, ContactPhone, DataaRogdeniya)" +
            //$" VALUES ({obj.INN},'{obj.Surname}', '{obj.Name}','{obj.MiddleName}', '{obj.ContactPhone}', '{date}')";
            string query = $"exec AddPerson {obj.INN}, '{obj.Surname}', '{obj.Name}', '{obj.MiddleName}', '{obj.ContactPhone}', '{date}'";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Query(query);
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public void Delete(int ID)
        {
            string query = $"exec dbo.DeleteAllAboutPerson {ID}";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Query(query);
            }
        }

        public Person Get(int ID)
        {
            string aSQL = "select INN, Surname as surname, Name, MiddleName, ContactPhone, RegistrationCity, DataaRogdeniya as DataRogdeniya from People where INN = @INN";
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

        private PersonRepository()
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
            string query = "select INN as iNN, Surname as surname, Name as name, MiddleName as middleName, " +
                "ContactPhone as contactPhone, RegistrationCity as registrationCity, DataaRogdeniya as dataRogdeniya from People";
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Person>(query);
            }
        }

        public Person[] GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        bool IRepository<Person>.Update(Person obj)
        {
            throw new NotImplementedException();
        }
    }
}
