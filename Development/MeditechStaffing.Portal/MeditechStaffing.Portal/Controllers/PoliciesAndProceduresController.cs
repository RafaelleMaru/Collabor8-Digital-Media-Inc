using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeditechStaffing.Portal.Controllers
{
    public class PoliciesAndProceduresController : Controller
    {
        // GET: PoliciesAndProcedures
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CommunityStaff()
        {
            return View();
        }

        public ActionResult BestPractices()
        {
            return View();
        }

    }
}