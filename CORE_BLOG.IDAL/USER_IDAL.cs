using CORE_BLOG.Entity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE_BLOG.IDAL
{
    public interface USER_IDAL
    {
        /// <summary>
        /// 获取用户登陆信息
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cmd"></param>
        /// <returns></returns>
        IList<USER> USER_LOGIN(string connection, string cmd);
    }
}
