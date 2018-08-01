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
        public IList<USER> USER_LOGIN(string connection,string userName,string userPassword)
        {
            return _uSER_IDAL.USER_LOGIN(connection, userName, userPassword);
        }
    }
}
