using System;
using Blog.Data;
using System.Data;
namespace Blog.Business.HomeController
{
    public class HomeModel
    {
        public HomeModel()
        {
            
        }
        public DataTable GetTestInfo()
        {
            Blog.Data.MysqlHelper mysqlHelper = new MysqlHelper();
            string sqlText = string.Format("SELECT * FROM BLOG.BLOG_ARTICLE_INFO;");
            DataTable dt = mysqlHelper.ExecuteDataSet(sqlText).Tables[0];
            return dt;
        }
    }
}
