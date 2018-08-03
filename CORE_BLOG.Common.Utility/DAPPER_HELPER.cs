using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE_BLOG.Common.Utility
{
    public abstract class DAPPER_HELPER<T>
    {
        /// <summary>
        /// 连接封装
        /// </summary>
        /// <param name="sqlConnectionString"></param>
        /// <returns></returns>
        public static MySqlConnection GetSqlConnection(string connection)
        {
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            return conn;
        }
    }
}
