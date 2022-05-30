using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Serves
    {
        public void CreateCommand(string queryString, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

