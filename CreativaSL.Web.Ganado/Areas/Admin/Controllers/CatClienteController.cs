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
    public class CatClienteController : Controller
    {
        string Conexion = ConfigurationManager.AppSettings.Get("strConnection");
        // GET: Admin/CatClientes
        public ActionResult Index()
        {
            try
            {
                CatClienteModels Cliente = new CatClienteModels();
                CatCliente_Datos ClienteD = new CatCliente_Datos();
                Cliente.Conexion = Conexion;
                Cliente = ClienteD.ObtenerClientes(Cliente);
                return View(Cliente);
            }
            catch (Exception)
            {
                CatClienteModels Cliente = new CatClienteModels();
                Cliente.ListaClientes = new List<CatClienteModels>();
                TempData["typemessage"] = "2";
                TempData["message"] = "No se puede cargar la vista";
                return View(Cliente);
            }
        }

        // GET: Admin/CatClientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CatClientes/Create
        public ActionResult Create()
        {
            try
            {
                CatClienteModels Clientes = new CatClienteModels();
                CatCliente_Datos ClientesDatos = new CatCliente_Datos();
                Clientes.EsPersonaFisica = true;
                Clientes.Conexion = Conexion;
                Clientes.ListaCmbSucursal = ClientesDatos.ObteneComboCatSucursal(Clientes);
                var list = new SelectList(Clientes.ListaCmbSucursal, "IDSucursal", "NombreSucursal");
                ViewData["cmbSucursal"] = list;
                Clientes.ListaRegimenCMB = ClientesDatos.ObtenerComboRegimenFiscal(Clientes);
                var list1 = new SelectList(Clientes.ListaRegimenCMB, "Clave", "Descripcion");
                ViewData["cmbRegimenFiscal"] = list1;
                return View(Clientes);
            }
            catch (Exception)
            {
                CatClienteModels Cliente = new CatClienteModels();
                TempData["typemessage"] = "2";
                TempData["message"] = "No se puede cargar la vista";
                return View(Cliente);
            }
        }

        // POST: Admin/CatClientes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                CatClienteModels Cliente = new CatClienteModels();
                CatCliente_Datos ClienteDatos = new CatCliente_Datos();
                Cliente.Conexion = Conexion;
                Cliente.Opcion = 1;
                Cliente.IDSucursal = collection["ListaCmbSucursal"];
                Cliente.IDRegimenFiscal = collection["ListaRegimenCMB"];
                Cliente.NombreRazonSocial = collection["NombreRazonSocial"];
                Cliente.RFC = collection["RFC"];
                Cliente.EsPersonaFisica = collection["EsPersonaFisica"].StartsWith("true");
                Cliente.Usuario = User.Identity.Name;
                Cliente = ClienteDatos.AbcCatClientes(Cliente);
                if (Cliente.Completado == true)
                {
                    TempData["typemessage"] = "1";
                    TempData["message"] = "Los datos se guardarón correctamente.";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["typemessage"] = "2";
                    TempData["message"] = "Ocurrio un error al intentar guardar los datos. Intente más tarde.";
                    return RedirectToAction("Create");
                }
               
            }
            catch
            {
                TempData["typemessage"] = "2";
                TempData["message"] = "Ocurrio un error al intentar guardar los datos. Contacte a soporte técnico.";
                return RedirectToAction("Index");
            }
        }

        // GET: Admin/CatClientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/CatClientes/Edit/5
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

        // GET: Admin/CatClientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/CatClientes/Delete/5
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
