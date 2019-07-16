using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Account.Models;



namespace Account.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {

            return View();
        }

       
        public ActionResult Data()
        {
            List<ViewModels> display = new List<ViewModels>();

            Random rdm = new Random();
            for (int i = 1; i <= 100; i++)
            {

                int randomnumber = rdm.Next(101);
                int randomtype = rdm.Next(1, 3);
                var randomdatetime = DateTime.Now.AddDays(randomnumber);
                int randommoney = rdm.Next(500, 3001);
                display.Add(new ViewModels
                {
                    Type = (randomtype == 1) ? "收入" : "支出",
                    DateTime = randomdatetime,
                    Money = randommoney,
                    Number = i,
                });
            }
            return View(display);
        }

       
      

    }
}