using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class StatementRepository : IRepository<Statement>
    {
        public bool Add(Statement obj)
        {
            string a = string.Join(", ", AcceptedDocuments(obj));
            string date = $"{obj.person.DataRogdeniya.Year}.{obj.person.DataRogdeniya.Month}.{obj.person.DataRogdeniya.Day} ";

            string query = $"exec AddPerson {obj.person.INN},'{obj.person.Surname}', '{obj.person.Name}','{obj.person.MiddleName}','{obj.person.RegistrationCity}', '{obj.person.ContactPhone}', '{date}' " +
            $" INSERT INTO Rassmotrenie(INN, IDpensy) VALUES ({obj.person.INN},{obj.typePensy.ID_}) "+
            AcceptedDocuments(obj);

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        connection.Query(query, transaction : transaction);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        private string AcceptedDocuments(Statement obj)
        {
            if (obj.documents.Count() == 0)
            {
                return "";
            }
            else
            {
                return "INSERT into AcceptedDocuments(INN, ID_documenta, DateDate, DateMonth, DateYear) VALUES " + string.Join(", ", 
                    obj.documents.Select(doc =>
                    $"({obj.person.INN}, {doc.ID_}, {obj.Date.Day}, {obj.Date.Month}, {obj.Date.Year})"
                ).ToArray());
            }
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Statement Get(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Statement> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Statement obj)
        {
            string date = $"{obj.person.DataRogdeniya.Year}.{obj.person.DataRogdeniya.Month}.{obj.person.DataRogdeniya.Day}";
            string query = "update People " +
            $"Set Surname = '{obj.person.Surname}', " +
            $"Name = '{obj.person.Name}'," +
            $" MiddleName = '{obj.person.MiddleName}'," +
            $" ContactPhone = '{obj.person.ContactPhone}', " +
            $"RegistrationCity = '{obj.person.RegistrationCity}', " +
            $"DataaRogdeniya = '{date}' " +
            "where INN = @INN "+
            AcceptedDocuments(obj);

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Query(query, new { INN = obj.person.INN});
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        private StatementRepository()
        {
        }

        private string connectionString;
        private static StatementRepository repository = new StatementRepository();

        public static void Configure(string connectionString)
        {
            repository.connectionString = connectionString;
        }

        public static StatementRepository GetRepository()
        {
            return repository;
        }

        public Statement[] GetByID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
