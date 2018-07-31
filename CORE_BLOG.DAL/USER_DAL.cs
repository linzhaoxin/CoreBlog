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
    public partial class USER_DAL : USER_IDAL
    {

        public  IList<USER> USER_LOGIN(string connection, string cmd)
        {
            IList<USER> _uSER = new List<USER>(); ;
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                IDbTransaction transaction = conn.BeginTransaction();
                try
                {
                    var a = conn.Query<USER>(cmd, null, transaction);
                    //提交事务
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    //出现异常，事务Rollback
                    transaction.Rollback();
                    throw new Exception(ex.Message);
                }
            }
            return _uSER;
            // return _dapperMySQLHelp.FindToList<USER>(connection, cmd, param, false); 
        }
    }
}
