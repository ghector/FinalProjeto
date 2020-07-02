using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjeto.Controllers
{
    [Authorize]
    public class ManageStatsController : Controller
    {
        // GET: ManageStats
        public ActionResult Index()
        {
            return View();
        }
    }
}