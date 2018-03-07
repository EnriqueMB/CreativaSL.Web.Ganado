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
    public class CatJaulaController : Controller
    {
        // GET: Admin/CatJaula
        string Conexion = ConfigurationManager.AppSettings.Get("strConnection");
        public ActionResult Index()
        {
            try
            {
                CatJaulaModels Jaula = new CatJaulaModels();
                _CatJaula_Datos JaulaDatos = new _CatJaula_Datos();
                Jaula.conexion = Conexion;
                Jaula.listaJaulas = JaulaDatos.obtenerCatJaula(Jaula);
               

                return View(Jaula);
            }
            catch (Exception ex)
            {
                CatLugarModels Lugar = new CatLugarModels();
                TempData["typemessage"] = "2";
                TempData["message"] = "No se puede cargar la vista";
                return View(Lugar);
            }
        }

        // GET: Admin/CatJaula/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Admin/CatJaula/Create
        public ActionResult Create()
        {
            try {
                CatJaulaModels Jaula = new CatJaulaModels();
                _CatJaula_Datos JaulaDatos = new _CatJaula_Datos();

                Jaula.listaSucursales = JaulaDatos.obtenerListaSucursales(Jaula);
                var listaSucursal = new SelectList(Jaula.listaSucursales, "IDSucursal", "NombreSucursal");
                ViewData["cmbSucursal"] = listaSucursal;
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: Admin/CatJaula/Create
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

        // GET: Admin/CatJaula/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/CatJaula/Edit/5
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

        // GET: Admin/CatJaula/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/CatJaula/Delete/5
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
