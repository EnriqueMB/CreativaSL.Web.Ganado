using CreativaSL.Web.Ganado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreativaSL.Web.Ganado.Areas.Admin.Controllers
{
    public class AlmacenController : Controller
    {
        // GET: Admin/Almacen
        /// <summary>
        /// Se mostrará el catálogo de almacenes de la sucursal actual (Dada por el usuario
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            CatAlmacenModels Almacen = new CatAlmacenModels();
            //CatAla ChoferDatos = new CatChofer_Datos();
            //Chofer.Conexion = Conexion;
            //Almacen.ListaAlmacen = ChoferDatos.ObtenerCatChofer(Chofer);
            List<CatAlmacenModels> Lista = new List<CatAlmacenModels>();
            Lista.Add(new CatAlmacenModels { ClaveAlmacen = "ALM-01-001", IDAlmacen = "0001", NombreSucursal = "Matriz Grupo Ocampo", Descripcion = "Almacén Norte" });
            Lista.Add(new CatAlmacenModels { ClaveAlmacen = "ALM-01-002", IDAlmacen = "0002", NombreSucursal = "Matriz Grupo Ocampo", Descripcion = "Almacén Sur" });
            Almacen.ListaAlmacen = Lista;
            return View(Almacen);
        }

        // GET: Admin/Almacen/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Almacen/Create
        public ActionResult Create()
        {
            CatAlmacenModels Almacen = new CatAlmacenModels();
            List<CatSucursalesModels> Lista = new List<CatSucursalesModels>();
            Lista.Add(new CatSucursalesModels { IDSucursal = "SUC01", NombreSucursal = "Matriz Grupo Ocampo"});
            Lista.Add(new CatSucursalesModels { IDSucursal = "SUC02", NombreSucursal = "Sucursal Frailesca"});
            Almacen.ListaSucursales = Lista;
            var list = new SelectList(Almacen.ListaSucursales, "IDSucursal", "NombreSucursal");
            ViewData["cmbSucursal"] = list;
            return View(Almacen);
        }

        // POST: Admin/Almacen/Create
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

        // GET: Admin/Almacen/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                CatAlmacenModels Almacen = new CatAlmacenModels();
                //CatChofer_Datos ChoferDatos = new CatChofer_Datos();
                //Chofer.IDChofer = id;
                //Chofer.Conexion = Conexion;
                //Chofer = ChoferDatos.ObtenerDetalleCatChofer(Chofer);
                return View(Almacen);
            }
            catch (Exception)
            {
                CatAlmacenModels Almacen = new CatAlmacenModels();
                TempData["typemessage"] = "2";
                TempData["message"] = "No se puede cargar la vista";
                return View(Almacen);
            }
        }

        // POST: Admin/Almacen/Edit/5
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

        // GET: Admin/Almacen/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Almacen/Delete/5
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
