using CORE_BLOG.DAL;
using CORE_BLOG.Entity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE_BLOG.BLL
{
    public class USER_LOGIN_BLL
    {
        USER_DAL _uSER_DAL = new USER_DAL();
        public IList<USER> USER_LOGIN(string connection,string userName,string userPassword)
        {
            var param = new DynamicParameters();
            string sql = "select USER_ID,USER_NAME,USER_PASSWORD,USER_ROLE from user  where USER_NAME=@USER_NAME and USER_PASSWORD=@USER_PASSWORD";
            param.Add("USER_NAME", userName);
            param.Add("USER_PASSWORD", userPassword);
            return _uSER_DAL.USER_LOGIN(connection, sql, param);
        }
    }
}
