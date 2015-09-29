using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class InboxController : Controller
    {
        // GET: Inbox
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult Inbox()
        {
            return PartialView("_Inbox");
        }

        [HttpGet]
        public PartialViewResult Compose()
        {
            return PartialView("_Compose");
        }

        [HttpGet]
        public PartialViewResult Reply()
        {
            return PartialView("_Reply");
        }

        [HttpGet]
        public PartialViewResult View(int id)
        {
            return PartialView("_Read");
        }

    }
}