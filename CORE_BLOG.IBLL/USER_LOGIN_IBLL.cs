using CORE_BLOG.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE_BLOG.IBLL
{
    public interface USER_LOGIN_IBLL
    {
        IList<USER> USER_LOGIN(string connection, string userName, string userPassword);
    }
}
