using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Class1
    {
        //public static string GetName()
        //{
        //    //string aSQL = "select Name, Surname from People";
        //    //string connectionString = @"Server=LAPTOP-TSM0D2RH\SQLEXPRESS;Database=Pensionny_Fond;User Id=admin; " +
        //    //    "Password = admin; ";
        //    //using (var connection = new SqlConnection(connectionString))
        //    //{
        //    //    var a = connection.Query<Person>(aSQL);
               
        //    //}
        //    //return null;
        //}
    }

    public class Person
    {
        public string INN { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string ContactPhone { get; set; }
        public string RegistrationCity { get; set; }
        public string DataRogdeniya { get; set; }
    }

}
