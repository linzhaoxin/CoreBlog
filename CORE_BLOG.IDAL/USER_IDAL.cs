﻿using CORE_BLOG.Entity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE_BLOG.IDAL
{
    public interface USER_IDAL
    {
        /// <summary>
        /// 用户的登陆查询
        /// </summary>
        /// <param name="connection">sql</param>
        /// <param name="userName">用户名称</param>
        /// <param name="userPassword">用户密码</param>
        /// <returns></returns>
        IList<USER> UserLogin(string connection, string userName, string userPassword);
    }
}
