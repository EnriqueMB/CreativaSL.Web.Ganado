﻿using CreativaSL.Web.Ganado.Filters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CreativaSL.Web.Ganado.Models;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace CreativaSL.Web.Ganado.Areas.Admin.Controllers
{
    [Autorizado]
    public class CatFierroController : Controller
    {
        string Conexion = ConfigurationManager.AppSettings.Get("strConnection");
        // GET: Admin/CatFierro
        public ActionResult Index()
        {
            try
            {
                CatFierroModels Fierro = new CatFierroModels();
                CatFierro_Datos FierroDa = new CatFierro_Datos();
                Fierro.Conexion = Conexion;
                Fierro = FierroDa.ObtenerListaFierros(Fierro);
                return View(Fierro);
            }
            catch (Exception)
            {
                CatFierroModels Fierro = new CatFierroModels();
                TempData["typemessage"] = "2";
                TempData["message"] = "No se puede cargar la vista";
                return View(Fierro);
            }
        }

        // GET: Admin/CatFierro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CatFierro/Create
        [HttpGet]
        public ActionResult Create()
        {
            try
            {
                CatFierroModels Fierro = new CatFierroModels();
                return View(Fierro);
            }
            catch (Exception)
            {
                CatFierroModels Fierro = new CatFierroModels();
                TempData["typemessage"] = "2";
                TempData["message"] = "No se puede cargar la vista";
                return View(Fierro);
            }
        }

        // POST: Admin/CatFierro/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                CatFierroModels Fierro = new CatFierroModels();
                CatFierro_Datos FierroDatos = new CatFierro_Datos();
                Fierro.Conexion = Conexion;
                Fierro.Opcion = 1;
                Fierro.Usuario = User.Identity.Name;
                Fierro.NombreFierro = collection["NombreFierro"];
                Fierro.Observaciones = collection["Observaciones"];
                HttpPostedFileBase bannerImage = Request.Files[0] as HttpPostedFileBase;
                if (bannerImage != null && bannerImage.ContentLength > 0)
                {
                    Stream s = bannerImage.InputStream;
                    Bitmap img = new Bitmap(s);
                    Fierro.ImgFierro = img.ToBase64String(ImageFormat.Png);
                }
                Fierro = FierroDatos.AbcCatFierro(Fierro);
                if (Fierro.Completado == true)
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
            catch (Exception ex)
            {
                TempData["typemessage"] = "2";
                TempData["message"] = "Ocurrio un error al intentar guardar los datos. Contacte a soporte técnico.";
                return RedirectToAction("Index");
            }
        }

        // GET: Admin/CatFierro/Edit/5
        [HttpGet]
        public ActionResult Edit(string id)
        {
            try
            {
                CatFierroModels Fierro = new CatFierroModels();
                CatFierro_Datos FierroDatos = new CatFierro_Datos();
                Fierro.IDFierro = id;
                Fierro.Conexion = Conexion;
                Fierro = FierroDatos.ObtenerDetalleCatFierro(Fierro);
                return View(Fierro);
            }
            catch (Exception)
            {
                CatFierroModels Fierro = new CatFierroModels();
                TempData["typemessage"] = "2";
                TempData["message"] = "No se puede cargar la vista";
                return View(Fierro);
            }
        }

        // POST: Admin/CatFierro/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                CatFierroModels Fierro = new CatFierroModels();
                CatFierro_Datos FierroDatos = new CatFierro_Datos();
                Fierro.Conexion = Conexion;
                Fierro.Opcion = 2;
                Fierro.Usuario = User.Identity.Name;
                Fierro.IDFierro = collection["IDFierro"];
                Fierro.NombreFierro = collection["NombreFierro"];
                Fierro.Observaciones = collection["Observaciones"];
                HttpPostedFileBase bannerImage = Request.Files[0] as HttpPostedFileBase;
                if (bannerImage != null && bannerImage.ContentLength > 0)
                {
                    Stream s = bannerImage.InputStream;
                    Bitmap img = new Bitmap(s);
                    Fierro.ImgFierro = img.ToBase64String(ImageFormat.Png);
                }
                Fierro = FierroDatos.AbcCatFierro(Fierro);
                if (Fierro.Completado == true)
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
            catch (Exception ex)
            {
                TempData["typemessage"] = "2";
                TempData["message"] = "Ocurrio un error al intentar guardar los datos. Contacte a soporte técnico.";
                return RedirectToAction("Index");
            }
        }

        // GET: Admin/CatFierro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/CatFierro/Delete/5
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
