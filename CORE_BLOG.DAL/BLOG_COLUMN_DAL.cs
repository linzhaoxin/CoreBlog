using CORE_BLOG.Common.Utility;
using CORE_BLOG.Entity;
using CORE_BLOG.IDAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CORE_BLOG.DAL
{
    public  class BLOG_COLUMN_DAL: DAPPER_HELPER<BLOG_COLUMN>, BLOG_COLUMN_IDAL
    {
        /// <summary>
        /// 用户个人的博客简介
        /// </summary>
        /// <param name="connection">连接字符串</param>
        /// <param name="personalid">用户信息id</param>
        /// <param name="start">开始条数</param>
        /// <param name="end">结束条数</param>
        /// <returns></returns>
        public IList<BLOG_COLUMN> BlogList(string connection,string personalid,int start, int end)
        {
            IList<BLOG_COLUMN> blog_column = new List<BLOG_COLUMN>();
            using (IDbConnection conn = GetSqlConnection(connection))
            {
                string sql = "SELECT * FROM BLOG_COLUMN BCN "+
                             "INNER JOIN BLOG_CONTENT BCT ON BCN.COLUMN_ID=BCT.COLUMN_ID "+
                             "WHERE BCN.PERSONAL_ID=@PERSONAL_ID LIMIT @Start,@End ";
                DynamicParameters param = new DynamicParameters();
                param.Add("PERSONAL_ID", personalid);
                param.Add("Start", start);
                param.Add("End", end);
                blog_column = conn.Query<BLOG_COLUMN, BLOG_CONTENT, BLOG_COLUMN>(sql, (column, content) => {
                    column.BLOG_CONTENT = content;
                    return column;
                }, param, splitOn: "CONTENT_ID").ToList();
            }
            return blog_column;
        }
    }
}
