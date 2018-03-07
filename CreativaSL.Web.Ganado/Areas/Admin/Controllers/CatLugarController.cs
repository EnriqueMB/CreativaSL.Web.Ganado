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
    public class CatLugarController : Controller
    {
        string Conexion = ConfigurationManager.AppSettings.Get("strConnection");
        // GET: Admin/CatLugar
        public ActionResult Index()
        {
            CatLugarModels Lugar = new CatLugarModels();
            _CatLugar_Datos LugarDatos = new _CatLugar_Datos();
            Lugar.conexion = Conexion;
            Lugar.listaLugares = LugarDatos.obtenerCatLugar(Lugar);
            return View(Lugar);
        }

        // GET: Admin/CatLugar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CatLugar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CatLugar/Create
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

        // GET: Admin/CatLugar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/CatLugar/Edit/5
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

        // GET: Admin/CatLugar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/CatLugar/Delete/5
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
