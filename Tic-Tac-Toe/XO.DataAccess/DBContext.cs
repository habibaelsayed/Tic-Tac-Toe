using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.XO.DataAccess
{
    public class DBContext
    {
        // select
        public static DataTable Select(string cmd, string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            return dt;
        }

        //delete, update, insert
        public static int ExecuteNonQuery(string cmd, string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);

            sqlConnection.Open();
            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return result;
        }

    }
}
