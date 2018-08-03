using CORE_BLOG.Entity;
using CORE_BLOG.IBLL;
using CORE_BLOG.IDAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE_BLOG.BLL
{
    public class USER_LOGIN_BLL: USER_LOGIN_IBLL
    {
        private USER_IDAL _uSER_IDAL;
        public USER_LOGIN_BLL(USER_IDAL uSER_IDAL)
        {
            this._uSER_IDAL = uSER_IDAL;
        }
        /// <summary>
        /// 用户的登陆查询
        /// </summary>
        /// <param name="connection">sql</param>
        /// <param name="userName">用户名称</param>
        /// <param name="userPassword">用户密码</param>
        /// <returns></returns>
        public IList<USER> UserLogin(string connection,string userName,string userPassword)
        {
            return _uSER_IDAL.UserLogin(connection, userName, userPassword);
        }
    }
}
