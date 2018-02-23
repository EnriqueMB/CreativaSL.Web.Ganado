using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CreativaSL.Web.Ganado.Models;
using System.Configuration;
using System.Security.Principal;

namespace CreativaSL.Web.Ganado.Filters
{
    public class AutorizadoAttribute : ActionFilterAttribute
    {
        string Conexion = ConfigurationManager.AppSettings.Get("strConnection");

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                if (HttpContext.Current.Session["SessionTipoUsuario"] == null)
                {
                    UsuarioModels Usuario = new UsuarioModels();
                    UsuarioDatos usuario_datos = new UsuarioDatos();
                    Usuario.conexion = Conexion;
                    IPrincipal user = HttpContext.Current.User;
                    Usuario.cuenta = user.Identity.Name;
                    int TipoUsario = usuario_datos.ObtenerTipoUsuarioByUserName(Usuario);
                    HttpContext.Current.Session["SessionTipoUsuario"] = TipoUsario;
                }
                if (HttpContext.Current.Session["SessionListaPermiso"] == null)
                {
                    UsuarioModels Usuario = new UsuarioModels();

                    LoginDatos LoginD = new LoginDatos();
                    Usuario.conexion = Conexion;
                    IPrincipal user = HttpContext.Current.User;
                    Usuario.cuenta = user.Identity.Name;
                    Usuario = LoginD.ObtenerPermisos(Usuario);
                    List<string> ListaPermiso = new List<string>();
                    foreach (var item in Usuario.ListaPermisos)
                    {
                        ListaPermiso.Add(item.NombreUrl);
                    }
                    HttpContext.Current.Session["SessionListaPermiso"] = ListaPermiso;
                }
                else
                {
                    int TipoUsuario = (int)HttpContext.Current.Session["SessionTipoUsuario"];
                    List<string> ListaPermiso = new List<string>();
                    ListaPermiso = (List<string>)HttpContext.Current.Session["SessionListaPermiso"];

                    HttpContext.Current.Session["SessionTipoUsuario"] = TipoUsuario;
                    HttpContext.Current.Session["SessionListaPermiso"] = ListaPermiso;
                }
            }

        }
    }
}