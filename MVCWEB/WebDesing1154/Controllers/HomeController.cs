using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CapaEntidad;
using capaNegocio;

namespace WebDesing1154.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuarios()
        {
            return View();
        }

        [HttpGet]
        public JsonResult listarUsuarios()
        {




                List<usuario> olista = new List<usuario>();
            olista = new CN_Usuarios().listar();
            return Json(new { data = olista }, JsonRequestBehavior.AllowGet);
        }


    }
}