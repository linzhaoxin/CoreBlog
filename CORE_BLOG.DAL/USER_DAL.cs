using CORE_BLOG.Entity;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CORE_BLOG.IDAL;

namespace CORE_BLOG.DAL
{
    public  class USER_DAL : USER_IDAL
    {

        public  IList<USER> USER_LOGIN(string connection, string userName, string userPassword)
        {
            string sql = "SELECT * FROM USER U " +
                         "INNER JOIN  USER_PERSONAL UP ON U.USER_ID = UP.USER_ID " +
                         "WHERE U.USER_NAME=@USER_NAME AND U.USER_PASSWORD=@USER_PASSWORD ";
            DynamicParameters param = new DynamicParameters();
            param.Add("USER_NAME", userName);
            param.Add("USER_PASSWORD", userPassword);
            IList<USER> _uSER = new List<USER>();
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                _uSER = conn.Query<USER,USER_PERSONAL,USER>(sql,(user, user_personal)=> {
                    user.USER_PERSONAL = user_personal;
                    return user;
                }, param, splitOn: "PERSONAL_ID").ToList();
            }
            return _uSER;
        }
    }
}
