using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppSecure.Controllers
{
    public class PerfilController : Controller
    {
        // GET: Perfil
        public ActionResult Index()
        {
            //creamos el primer controlador desde mi cuenta
            return View();
        }
    }
}