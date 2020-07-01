using FinalProjeto.Core.Domain;
using FinalProjeto.Persistance;
using FinalProjeto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjeto.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork db = new UnitOfWork(new ApplicationDbContext());
        public ActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel()
            {
                Movies = db.Movies.GetAll(5)

            };

            return View(vm);
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