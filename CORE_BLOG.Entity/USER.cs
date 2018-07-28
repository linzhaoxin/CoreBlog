using System;
using System.Collections.Generic;
using System.Text;

namespace CORE_BLOG.Entity
{
    /// <summary>
    /// user:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class USER
    {
        public USER()
        { }
        #region Model
        private int _user_id;
        private string _user_name;
        private string _user_password;
        private UInt64 _user_role;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int USER_ID
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string USER_NAME
        {
            set { _user_name = value; }
            get { return _user_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string USER_PASSWORD
        {
            set { _user_password = value; }
            get { return _user_password; }
        }
        /// <summary>
        /// 
        /// </summary>
        public UInt64 USER_ROLE
        {
            set { _user_role = value; }
            get { return _user_role; }
        }
        #endregion Model

    }
}
