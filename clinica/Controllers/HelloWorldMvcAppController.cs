using clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clinica.Controllers
{
    public class HelloWorldMvcAppController : Controller
    {
        // GET: HelloWorldMvcApp
        [HttpGet]
        public ActionResult Index()
        {
            List<SelectListItem> item8 = new List<SelectListItem>();
            item8.Add(new SelectListItem
            {
                Text = "USA",
                Value = "1"
            });
            ViewBag.country = item8;

            return View(new SampleViewModel());
        }
    }
}