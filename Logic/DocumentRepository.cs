using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Logic
{
    public class DocumentRepository : IRepository<Document>
    {
        public void Add(Document obj)
        {
            //string query = "INSERT into AcceptedDocuments(INN, ID_documenta, DateDate, DateMonth, DateYear)" +
            //    $"VALUES ({obj.ID_Person}, {obj.ID_Document}, {obj.day}, {obj.mounth}, {obj.year})";
            string query = "";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Query(query);
            }
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public void Update(Document obj)
        {
            throw new NotImplementedException();
        }

        public Document Get(int ID)
        {
            throw new NotImplementedException();
        }


        private DocumentRepository()
        {
        }

        private string connectionString;
        private static DocumentRepository repository = new DocumentRepository(); 

        public static void Configure(string connectionString)
        {
            repository.connectionString = connectionString;
        }

        public static DocumentRepository GetRepository()
        {
            return repository;
        }

        public IEnumerable<Document> GetAll()
        {
            string query = "select NumberOfTypeD as id, TypeOfDocument as name from TypeOfDocuments";
            using (var connection = new SqlConnection(connectionString))
            {
               return connection.Query<Document>(query);
            }
        }
    }
}
