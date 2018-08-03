using CORE_BLOG.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE_BLOG.IDAL
{
    public interface  BLOG_COLUMN_IDAL
    {
        /// <summary>
        /// 用户个人的博客简介
        /// </summary>
        /// <param name="connection">连接字符串</param>
        /// <param name="personalid">用户信息id</param>
        /// <param name="start">开始条数</param>
        /// <param name="end">结束条数</param>
        /// <returns></returns>
        IList<BLOG_COLUMN> BlogList(string connection, string personalid, int start, int end);
    }
}
