using System;
using System.Collections.Generic;
using System.Text;

namespace CORE_BLOG.Entity
{

    /// <summary>
    /// blog_content:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class BLOG_CONTENT
    {
        public BLOG_CONTENT()
        { }
        #region Model
        private int _content_id;
        private int _column_id;
        private string _content_information;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int CONTENT_ID
        {
            set { _content_id = value; }
            get { return _content_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int COLUMN_ID
        {
            set { _column_id = value; }
            get { return _column_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTENT_INFORMATION
        {
            set { _content_information = value; }
            get { return _content_information; }
        }
        #endregion Model

    }
}
