﻿using Microsoft.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace TrainingFPT
{
    public class Database
    {
        public static string GetStringConnection()
        {
            string strConnection = @"Data Source=DUONG\SQLEXPRESS;Initial Catalog=Training FPT;Integrated Security=True;Trust Server Certificate=True";
            return strConnection;
        }

        public static SqlConnection GetSqlConnection() 
        {
            string strConnection = GetStringConnection();
            SqlConnection connection = new SqlConnection(strConnection);
            return connection;
        }
    }
}
