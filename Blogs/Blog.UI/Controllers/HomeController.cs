using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Blog.Business;
using System.Data;
namespace Blog.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View();
        }

       

        public ActionResult TestView()
        {
            
            ViewData["test"] = "test";
            return View();
        }

        public ActionResult Testpartion()
        {
			Blog.Business.HomeController.HomeModel hm = new Business.HomeController.HomeModel();
			var dt = hm.GetTestInfo();
			string testInfo = string.Empty;
			foreach (DataRow dr in dt.Rows)
			{
				testInfo += string.Format(@" id={0}  author={1} content={2} ", dr["ID"].ToString(), dr["AUTHORER"].ToString(), dr["ARTICLE_CONTENT"].ToString());

			}
            ViewData["test"] =testInfo;
            return View();
        }
    }
}
