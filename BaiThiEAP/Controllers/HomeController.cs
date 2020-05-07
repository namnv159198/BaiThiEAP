using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiThiEAP.Models;

namespace BaiThiEAP.Controllers
{
    public class HomeController : Controller
    {
        public static Account acResult = new Account();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View(acResult);
        }
        public ActionResult Tranfers()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Tranfers(Account ac)
        {
            var account = new ServiceReference1.Service1Client();
            var result = account.GetAccount(ac.Code, ac.Password);
            if (result != null)
            {
                acResult.Username = result.Username;
                acResult.Blance = result.Blance;
                return RedirectToAction("About",acResult);
            }
            else
            {
                ViewBag.error = "Account not Exist";
                return View();
            }
            
        }

       

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}