using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiv2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WebApi(int data1, int data2, int data3)
        {
            int data4 = 0;
   
            //First create the set range using data1 and data2.
            IEnumerable<int> result = Enumerable.Range(data1, data2);

            //Second write the script to locate the value in a set given data3. Finally store the index's number in data4.
            IList<int> list = new List<int>(result);
            data4 = list.ElementAt(data3);

            ViewData["Data1"] = data1;
            ViewData["Data2"] = data2;
            ViewData["Data3"] = data3;
            ViewData["Data4"] = data4;
            return View();
        }
    }
}
