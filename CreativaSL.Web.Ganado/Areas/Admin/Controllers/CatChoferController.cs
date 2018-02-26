using CreativaSL.Web.Ganado.Filters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CreativaSL.Web.Ganado.Models;
using System.Data;

namespace CreativaSL.Web.Ganado.Areas.Admin.Controllers
{
    [Autorizado]
    public class CatChoferController : Controller
    {
        string Conexion = ConfigurationManager.AppSettings.Get("strConnection");
        // GET: Admin/CatChofer
        public ActionResult Index()
        {
            try
            {
                CatChoferModels Chofer = new CatChoferModels();
                CatChofer_Datos ChoferDatos = new CatChofer_Datos();
                Chofer.Conexion = Conexion;
                Chofer = ChoferDatos.ObtenerCatChofer(Chofer);
                return View(Chofer);
            }
            catch (Exception)
            {
                CatChoferModels Chofer = new CatChoferModels();
                Chofer.TablaDatos = new DataTable();
                TempData["typemessage"] = "2";
                TempData["message"] = "No se puede cargar la vista";
                return View(Chofer);
            }
        }

        // GET: Admin/CatChofer/Create
        public ActionResult Create()
        {
            try
            {
                CatChoferModels Chofer = new CatChoferModels();
                Chofer.Licencia = Convert.ToBoolean("true");
                return View(Chofer);
            }
            catch (Exception)
            {
                CatChoferModels Chofer = new CatChoferModels();
                TempData["typemessage"] = "2";
                TempData["message"] = "No se puede cargar la vista";
                return View(Chofer);
            }            
        }

        // POST: Admin/CatChofer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/CatChofer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/CatChofer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/CatChofer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/CatChofer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
