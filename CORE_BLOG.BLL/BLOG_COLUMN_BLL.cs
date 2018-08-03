using CORE_BLOG.Entity;
using CORE_BLOG.IBLL;
using CORE_BLOG.IDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE_BLOG.BLL
{
    public class BLOG_COLUMN_BLL: BLOG_COLUMN_IBLL
    {
        private BLOG_COLUMN_IDAL _bLOG_COLUMN_IDAL;
        public BLOG_COLUMN_BLL(BLOG_COLUMN_IDAL bLOG_COLUMN_IDAL)
        {
            this._bLOG_COLUMN_IDAL = bLOG_COLUMN_IDAL;
        }
        /// <summary>
        /// 用户个人的博客简介
        /// </summary>
        /// <param name="connection">连接字符串</param>
        /// <param name="personalid">用户信息id</param>
        /// <param name="start">开始条数</param>
        /// <param name="end">结束条数</param>
        /// <returns></returns>
        public IList<BLOG_COLUMN> BlogList(string connection, string personalid, int start, int end)
        {
            return _bLOG_COLUMN_IDAL.BlogList(connection, personalid, start, end);
        }
    }
}
