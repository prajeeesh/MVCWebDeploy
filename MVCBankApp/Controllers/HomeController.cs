using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankAccountNS;

namespace MVCBankApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BankAccount ba = new BankAccount("Mr. Baker", 1200.50);

            ba.Credit(5.77);
            string accountDetails = "Customer Name: " + ba.CustomerName + " and Balance :" + ba.Balance;
            ViewBag.AccDetails = accountDetails;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}