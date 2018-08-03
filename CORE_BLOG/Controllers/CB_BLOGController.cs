using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CORE_BLOG.Entity;
using CORE_BLOG.IBLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace CORE_BLOG.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CB_BLOGController : Controller
    {
        private CONNECTION_STRINGS _cONNECTION;
        private BLOG_COLUMN_IBLL _bLOG_COLUMN;
        public CB_BLOGController(BLOG_COLUMN_IBLL bLOG_COLUMN, IOptions<CONNECTION_STRINGS> setting)
        {
            this._bLOG_COLUMN = bLOG_COLUMN;
            _cONNECTION = setting.Value;
        }
        /// <summary>
        /// 用户的个人博客信息
        /// </summary>
        /// <param name="obj">dynamic包含的数据体请求参数</param>
        /// <returns></returns>
        [HttpGet]
        [HttpPost]
        public string BlogList([FromBody]dynamic obj)
        {
            try
            {
                //string connection, string personalid, string start, string end
                string personalid = obj.PERSONAL_ID.ToString();
                int start = int.Parse(obj.start.ToString());
                int end = int.Parse(obj.end.ToString());
                var blogList = _bLOG_COLUMN.BlogList(_cONNECTION.MySqlConnection, personalid, start, end);
                return JsonConvert.SerializeObject(blogList);
            }
            catch
            {
                return "Error";
            }
        }
    }
}