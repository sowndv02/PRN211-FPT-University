using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Q1_PE_Fall21B5.DAL
{
    internal class DAO
    {
        public static SqlConnection GetConnection()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string ConnectionStr = config.GetConnectionString("DefaultConnection");
            return new SqlConnection(ConnectionStr);
        }

        public static DataTable GetDataBySql(string sql, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            if (parameters != null || parameters.Length != 0) cmd.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        public static int ExcuteBySql(string sql, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            if (parameters != null || parameters.Length != 0) cmd.Parameters.AddRange(parameters);
            cmd.Connection.Open();
            int count = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return count;
        }
    }
}
