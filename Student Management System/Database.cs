using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Database
    {
        private static string connectionString = @"server=ASUSVIVOBOOK;database=StudentManagement;integrated security=true;";
        //Change with your server and database name
        public static DataTable Query(string sqlCommand)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
        public static void Execute(string sqlCommand)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static DataTable Query(string sqlCommand, Dictionary<string, object> parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            foreach (string name in parameters.Keys)
            {
                SqlParameter param = new SqlParameter(name, parameters[name]);
                command.Parameters.Add(param);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
        public static void Execute(string sqlCommand, Dictionary<string, object> parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            foreach (string name in parameters.Keys)
            {
                SqlParameter param = new SqlParameter(name, parameters[name]);
                command.Parameters.Add(param);
            }
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
