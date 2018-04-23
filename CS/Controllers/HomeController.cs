using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridViewAndBootstrapMvc.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult GridViewPartial() {
            return PartialView(NorthwindDataProvider.GetProducts());
        }
    }
}