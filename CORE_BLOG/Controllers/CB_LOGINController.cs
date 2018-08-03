using System;
using System.Collections.Generic;
using System.Linq;
using CORE_BLOG.Entity;
using CORE_BLOG.IBLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace CORE_BLOG.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CB_LOGINController : Controller
    {
        private CONNECTION_STRINGS _cONNECTION;
        private USER_LOGIN_IBLL _uSER_LOGIN_IBLL;
        public CB_LOGINController(USER_LOGIN_IBLL uSER_LOGIN_IBLL, IOptions<CONNECTION_STRINGS> setting)
        {
            this._uSER_LOGIN_IBLL = uSER_LOGIN_IBLL;
            _cONNECTION = setting.Value;
        }

        [HttpGet]
        [HttpPost]
        //根据用户的信息进行登陆
        public string UserLogin([FromBody]dynamic obj)
        {
            try
            {
                // 用户名称
                string userName = obj.USER_NAME.ToString();
                //用户密码
                string userPassword = obj.USER_PASSWORD.ToString();
                var userList = _uSER_LOGIN_IBLL.UserLogin(_cONNECTION.MySqlConnection, userName, userPassword);
                return JsonConvert.SerializeObject(userList);
            }
            catch (Exception ex)
            {
                return "Error";
            }
        }
    }
}