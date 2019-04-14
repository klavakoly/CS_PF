using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logic.Security
{
    public class Autentification
    {
        public bool CheckLogin(string login, string password)
        {          
            string connectionString = @"Server=LAPTOP-TSM0D2RH\SQLEXPRESS;Database=Pensionny_Fond;User Id="+login+"; " +
                "Password ="+password+"; ";
           try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            } catch(Exception e)
            {
                return false;
            }
        }

        public Roles GetRole(string login, string password)
        {
            string connectionString = @"Server=LAPTOP-TSM0D2RH\SQLEXPRESS;Database=Pensionny_Fond;User Id=" + login + "; " +
                "Password =" + password + "; ";
            string query = $"select dbo.Role_ID('{login}')";
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Roles>(query).First();               
            }            
        }
    }
}
