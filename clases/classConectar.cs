using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PruebaConocimiento.clases;

namespace PruebaConocimiento.clases
{
    public class classConectar
    {
        public SqlConnection conn;
        classVariables classvarialbes = new classVariables();

        private void OpenConection()
        {
            conn = new SqlConnection
            {
                ConnectionString = classvarialbes.stringconnection
            };
            conn.Open();
        }

        private void CloseConection()
        {
            conn.Dispose();
            conn.Close();
        }

        private SqlCommand Command(string sql)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conn,
                CommandText = sql
            };
            return command;
        }

        public DataTable Sqldatatable(string sql)
        {
            SqlDataAdapter adapt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            OpenConection();
            adapt.SelectCommand = Command(sql);
            adapt.Fill(dt);
            CloseConection();
            return dt;
        }
    }
}