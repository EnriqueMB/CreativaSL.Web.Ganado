﻿using CreativaSL.Web.Ganado.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CreativaSL.Web.Ganado
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-MX");
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }
        protected void Application_PostRequestHandlerExecute(object sender, EventArgs e) //EndRequest
        {
            IPrincipal usr = HttpContext.Current.User;
            // If we are dealing with an authenticated forms authentication request
            if (usr.Identity.IsAuthenticated && usr.Identity.AuthenticationType == "Forms")
            {
                var httpApp = (HttpApplication)sender;
                string URL = httpApp.Request.FilePath.ToLower();
                string[] URLS = System.Text.RegularExpressions.Regex.Split(URL, "/");
                if (httpApp.Request.RawUrl.Split('/').Length > 2)
                {
                    string URLValida = URLS[2];
                    HttpContext context = HttpContext.Current;
                    if (context != null && context.Session != null)
                    {
                        int TipoUsuario = (int)HttpContext.Current.Session["SessionTipoUsuario"];
                        List<string> ListaPermiso = new List<string>();
                        ListaPermiso = (List<string>)HttpContext.Current.Session["SessionListaPermiso"];

                        if (URLValida == "account" || URLValida == "requestdata")
                        {

                        }
                        else
                        {
                            //LoginDatos login = new LoginDatos();
                            //login.xxxxxx(new CatAdministrativoModels { conexion = ConfigurationManager.AppSettings.Get("strConnection"), nombre = URLValida });
                            if (string.IsNullOrEmpty(ListaPermiso.Find(x => x.Equals(URLValida))))
                            {
                                if (TipoUsuario == 3)
                                {
                                    Response.Redirect("/Admin/Account");
                                    //mandar a login
                                }
                                else if (TipoUsuario == 1)
                                {
                                    Response.Redirect("/Admin/Account");
                                }
                            }
                        }
                    }

                }
            }

        }
    }
}
