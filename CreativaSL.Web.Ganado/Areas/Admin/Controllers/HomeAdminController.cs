using CreativaSL.Web.Ganado.Filters;
using CreativaSL.Web.Ganado.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreativaSL.Web.Ganado.Areas.Admin.Controllers
{
    [Autorizado]
    public class HomeAdminController : Controller
    {
        string Conexion = ConfigurationManager.AppSettings.Get("strConnection");
        // GET: Admin/HomeAdmin
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/HomeAdmin
        //[HttpGet]
        public ActionResult LoadMenu()
        {
            try
            {
                MenuModels Menu = new MenuModels();
                Menu_Datos MenuD = new Menu_Datos();
                Menu.Conexion = Conexion;
                Menu.User = User.Identity.Name;
                Menu.TipoMenu = 1;
                Menu = MenuD.ObtenerAllPermisoUsuario(Menu);
                return View(Menu);
            }
            catch (Exception)
            {
                MenuModels Menu = new MenuModels();
                return View(Menu);
            }
        }

        
    }
}