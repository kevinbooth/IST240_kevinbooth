using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapIntroduction.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Kevin Booth Technologies";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us";

            return View();
        }
        public ActionResult CalcApp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalcApp(string ValueA, string ValueB, string Calc)
        {
            int a;
            int b;
            string calcType = Calc;
            int answer = 0;

            if (ValueA != "" && ValueB != "")
            {
                a = Convert.ToInt32(ValueA);
                b = Convert.ToInt32(ValueB);

                switch (calcType)
                {
                    case "add":
                        answer = a + b;
                        break;
                    case "subtract":
                        answer = a - b;
                        break;
                    case "multiply":
                        answer = a * b;
                        break;
                    case "divide":
                        answer = a / b;
                        break;
                    default:
                        break;
                }

            }
            else { return View("CalcApp", (object)"Please enter a number!"); }
            return View("CalcApp", (object)answer.ToString());
        }
    }
}