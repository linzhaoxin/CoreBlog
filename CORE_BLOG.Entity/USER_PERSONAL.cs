using System;
using System.Collections.Generic;
using System.Text;

namespace CORE_BLOG.Entity
{
    /// <summary>
    /// user_personal:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class USER_PERSONAL
    {
        public USER_PERSONAL()
        { }
        #region Model
        private int _personal_id;
        private int _user_id;
        private string _personal_name;
        private bool _personal_gender;
        private string _personal_phone;
        private string _personal_country;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int PERSONAL_ID
        {
            set { _personal_id = value; }
            get { return _personal_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int USER_ID
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PERSONAL_NAME
        {
            set { _personal_name = value; }
            get { return _personal_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool PERSONAL_GENDER
        {
            set { _personal_gender = value; }
            get { return _personal_gender; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PERSONAL_PHONE
        {
            set { _personal_phone = value; }
            get { return _personal_phone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PERSONAL_COUNTRY
        {
            set { _personal_country = value; }
            get { return _personal_country; }
        }
        #endregion Model

    }
}
