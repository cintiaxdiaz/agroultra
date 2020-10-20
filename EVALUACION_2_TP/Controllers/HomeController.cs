using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EVALUACION_2_TP.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult inicio_sesion()
        {
            return View("/Views/inicio_sesion/inicio_sesion.cshtml");
        }

        public ActionResult Usuarios()
        {
            return View("/Views/Usuarios/Usuarios.cshtml");
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}