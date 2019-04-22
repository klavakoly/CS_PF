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
        public bool Add(Document obj)
        {
            //string query = "INSERT into AcceptedDocuments(INN, ID_documenta, DateDate, DateMonth, DateYear)" +
            //    $"VALUES ({obj.ID_Person}, {obj.ID_Document}, {obj.day}, {obj.mounth}, {obj.year})";
            string query = "";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Query(query);
                }
                return true;
            }catch (Exception e)
            {
                return false;
            }
        }

        public Document[] GetDocumentsForPency(int ID_Pency)
        {
            string query = $"select * from DocumentsForPency({ID_Pency})";
            Document[] res = null;
            using (var connection = new SqlConnection(connectionString))
            {
                res = connection.
                    Query<Document>(query).ToArray();
            }
            return res;
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


        public Document[] GetByID(int ID)
        {
            string query = "select ID_documenta as id, TypeOfDocument as name from AcceptedDocuments " +
                           "join TypeOfDocuments on ID_documenta = NumberOfTypeD where INN = @INN";
            Document[] res = null;
            using (var connection = new SqlConnection(connectionString))
            {
                res = connection.
                    Query<Document>(query, new { INN = ID }).ToArray();
            }
            return res;
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Document Get(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Update(Document obj)
        {
            throw new NotImplementedException();
        }
    }
}
