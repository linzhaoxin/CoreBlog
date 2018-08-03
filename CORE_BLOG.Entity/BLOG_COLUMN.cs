using System;
using System.Collections.Generic;
using System.Text;

namespace CORE_BLOG.Entity
{
    /// <summary>
    /// blog_column:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class BLOG_COLUMN
    {
        public BLOG_COLUMN()
        { }
        #region Model
        private int _column_id;
        private int _personal_id;
        private string _column_name;
        private string _colum_synopsis;
        private DateTime? _column_creationtime;
        private DateTime? _column_upatatime;
        private BLOG_CONTENT _blog_content;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int COLUMN_ID
        {
            set { _column_id = value; }
            get { return _column_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int PERSONAL_ID
        {
            set { _personal_id = value; }
            get { return _personal_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string COLUMN_NAME
        {
            set { _column_name = value; }
            get { return _column_name; }
        }
        

        public string COLUMN_SYNOPSIS
        {
            set { _colum_synopsis = value; }
            get { return _colum_synopsis; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? COLUMN_CREATIONTIME
        {
            set { _column_creationtime = value; }
            get { return _column_creationtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? COLUMN_UPATATIME
        {
            set { _column_upatatime = value; }
            get { return _column_upatatime; }
        }

        public BLOG_CONTENT BLOG_CONTENT
        {
            set { _blog_content = value; }
            get { return _blog_content; }
            
        }
        #endregion Model

    }
}
