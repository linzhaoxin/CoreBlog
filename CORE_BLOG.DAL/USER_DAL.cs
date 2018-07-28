using CORE_BLOG.Common.Utility;
using CORE_BLOG.Entity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE_BLOG.DAL
{
    public class USER_DAL
    {
        DapperMySQLHelp _dapperMySQLHelp = new DapperMySQLHelp();
        public IList<USER> USER_LOGIN(string connection,string cmd, DynamicParameters param)
        {
            return _dapperMySQLHelp.FindToList<USER>(connection, cmd, param, false); 
        }
    }
}
