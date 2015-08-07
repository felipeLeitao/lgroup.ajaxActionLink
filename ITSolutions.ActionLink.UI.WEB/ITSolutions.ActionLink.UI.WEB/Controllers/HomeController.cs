using ITSolutions.ActionLink.UI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITSolutions.ActionLink.UI.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly NORTHWNDContext db = new NORTHWNDContext();


        // GET: Home
        public ActionResult Index()
        {
            var model = db.Categories.ToList();
            return View(model);
        }

        [HttpGet]
        public ActionResult ListaProdutos(string categoria)
        {
            var model = db.Products.Where(x => x.Category.CategoryName == categoria).ToList();

            return View(model);
        }
    }
}