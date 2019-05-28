using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcpractice1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult GetNewInfo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Summary(string name, string lastName, string streetAddress, string state, string zipcode)
        {
            Models.NewUser user = new Models.NewUser();
            user.Name = name;
            user.LastName = lastName;
            user.StreetAddress = streetAddress;
            user.State = state;
            user.ZipCode = zipcode;
            return View(user);

        }
        public ActionResult SummaryPage(NewUser user1)
        {
            return View(user1);
        }
    }
}