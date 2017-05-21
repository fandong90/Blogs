using System;
namespace Blog.UI.Models
{
    public class ArticleInfo
    {
        public ArticleInfo()
        {
        }

        /// <summary>
        /// 文章ID
        /// </summary>
        /// <value>The identifier.</value>
        public string ID
        {
            get;
            set;
        }
        /// <summary>
        /// 文章标题
        /// </summary>
        /// <value>The tilte.</value>
        public string Tilte
        {
            get;
            set;
        }

        /// <summary>
        /// 文章内容
        /// </summary>
        /// <value>The content.</value>
        public string Content
        {
            get;
            set;
      
        }
        /// <summary>
        /// 作者
        /// </summary>
        /// <value>The authore.</value>
        public string Authore
        {
            get;
            set;
      
        }
        /// <summary>
        /// 提价日期
        /// </summary>
        /// <value>The commit date.</value>
        public DateTime CommitDate
        {
            get;
            set;
        }
    }
}
