using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CORE_BLOG.BLL;
using CORE_BLOG.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace CORE_BLOG.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CB_LOGINController : Controller
    {
        USER_LOGIN_BLL _uSER_LOGIN_BLL = new USER_LOGIN_BLL();
        public CONNECTION_STRINGS _cONNECTION;
        
        public CB_LOGINController(IOptions<CONNECTION_STRINGS> setting)
        {
            _cONNECTION = setting.Value;
        }

        [HttpPost]
        //根据用户的信息进行登陆
        public string USER_LOGIN([FromBody]dynamic obj)
        {
            try
            {
                // 用户名称
                string userName = obj.USER_NAME.ToString();
                //用户密码
                string userPassword = obj.USER_PASSWORD.ToString();
                var userList = _uSER_LOGIN_BLL.USER_LOGIN(_cONNECTION.MySqlConnection, userName, userPassword);
                return JsonConvert.SerializeObject(userList);
            }
            catch (Exception ex)
            {
                return "系统出现错误,请联系管理员.";
            }
        }
    }
}