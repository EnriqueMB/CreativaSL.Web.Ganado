using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CreativaSL.Web.Ganado.Models;

namespace CreativaSL.Web.Ganado.Areas.Admin.Controllers
{
    public class CompraController : Controller
    {
        public List<SelectListItem> Vehicles { get; private set; }

        string Conexion = ConfigurationManager.AppSettings.Get("strConnection");
        // GET: Admin/Compra
        public ActionResult Index()
        {
            try
            {
                CompraModels Compra = new CompraModels();
                _Compra_Datos CompraDatos = new _Compra_Datos();
                Compra.Conexion = Conexion;
                Compra = CompraDatos.ObtenerCompraIndex(Compra);
                return View(Compra);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Admin/Compra/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Compra/Create
        public ActionResult Create()
        {
            try
            {
                int i;
                CompraModels Compra = new CompraModels();
                _Compra_Datos CompraDatos = new _Compra_Datos();
                Compra.Conexion = Conexion;

                /*Relleno el combobox de proveedores*/
                Compra.TablaProveedoresCmb = CompraDatos.ObtenerListadoProveedores(Compra);
                var ListProveedores = new SelectList(Compra.TablaProveedoresCmb, "IDProveedor", "NombreRazonSocial");
                ViewData["cmbProveedores"] = ListProveedores;

                /*Relleno el combobox de Choferes*/
                Compra.Chofer = new CatChoferModels
                {
                    ListaChoferes = CompraDatos.ObtenerListadoChoferes(Compra)
                };
                List<SelectListItem> ListaChoferes = new List<SelectListItem>();
                SelectListItem ItemChofer;

                for (i = 0; i < Compra.Chofer.ListaChoferes.Count; i++)
                {
                    ItemChofer = new SelectListItem
                    {
                        Text = Compra.Chofer.ListaChoferes[i].Nombre.ToString() + " " + Compra.Chofer.ListaChoferes[i].ApPaterno.ToString() + " " + Compra.Chofer.ListaChoferes[i].ApMaterno.ToString(),
                        Value = Compra.Chofer.ListaChoferes[i].id_licencia.ToString()
                    };
                    ListaChoferes.Add(ItemChofer);
                }
                var ListChoferes = new SelectList(ListaChoferes, "Value", "Text");
                ViewData["cmbChoferes"] = ListChoferes;

                /*Relleno el combobox de vehículos*/
                Compra = CompraDatos.ObtenerVehiculos(Compra);
                CompraModels c;
                List<CompraModels> lc = new List<CompraModels>();

                c = new CompraModels
                {
                    Id_vehiculo = "0",
                    DescripcionVehiculo = "SELECCION UN VEHICULO",
                    Group = "GRUPO OCAMPO"
                };
                lc.Add(c);

                foreach (System.Data.DataRow Vehiculo in Compra.TablaVehiculos.Rows)
                {
                    c = new CompraModels();
                    c.Id_vehiculo = Vehiculo["id_vehiculo"].ToString();
                    c.DescripcionVehiculo = Vehiculo["marca"].ToString() + " | " + Vehiculo["placa"].ToString();
                    c.Group = Vehiculo["tipo"].ToString();
                    lc.Add(c);
                }

                var ListVehiculos = new SelectList(lc, "Id_vehiculo", "DescripcionVehiculo", "Group", 1);
                ViewData["cmbVehiculos"] = ListVehiculos;

                /*Relleno el combobox de lugares INICIO*/
                Compra = CompraDatos.ObtenerLugares(Compra, 1);
                CompraModels CompraLugar = new CompraModels();
                Compra.Lugar = new CatLugarModels
                {
                    listaLugares = new List<CatLugarModels>()
                };


                foreach (System.Data.DataRow Lugar in Compra.TablaLugares.Rows)
                {
                    CompraLugar.Lugar = new CatLugarModels
                    {
                        id_lugar = Lugar["id_lugar"].ToString() + " | " + Lugar["gpsLatitud"].ToString() + " | " + Lugar["gpsLongitud"].ToString(),
                        descripcion = Lugar["descripcion"].ToString()
                    };

                    Compra.Lugar.listaLugares.Add(CompraLugar.Lugar);
                }
                var ListLugaresInicio = new SelectList(Compra.Lugar.listaLugares, "id_lugar", "descripcion");
                ViewData["cmbLugarInicio"] = ListLugaresInicio;

                /*Relleno el combobox de lugares FINAL*/
                Compra = new CompraModels
                {
                    Conexion = Conexion
                };
                Compra = CompraDatos.ObtenerLugares(Compra, 0);
                Compra.Lugar = new CatLugarModels
                {
                    listaLugares = new List<CatLugarModels>()
                };

                foreach (System.Data.DataRow Lugar in Compra.TablaLugares.Rows)
                {
                    CompraLugar.Lugar = new CatLugarModels
                    {
                        id_lugar = Lugar["id_lugar"].ToString() + " | " + Lugar["gpsLatitud"].ToString() + " | " + Lugar["gpsLongitud"].ToString(),
                        descripcion = Lugar["descripcion"].ToString()
                    };

                    Compra.Lugar.listaLugares.Add(CompraLugar.Lugar);
                }
                var ListLugaresFinal = new SelectList(Compra.Lugar.listaLugares, "id_lugar", "descripcion");
                ViewData["cmbLugarFinal"] = ListLugaresFinal;


                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: Admin/Compra/Create
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

        // GET: Admin/Compra/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Compra/Edit/5
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

        // GET: Admin/Compra/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Compra/Delete/5
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

        [HttpPost]
        public ActionResult GetDataProveedor(string id_proveedor)
        {
            try
            {
                _Compra_Datos CompraDatos = new _Compra_Datos();
                return Json(CompraDatos.ObtenerDatosProveedorPorID(Conexion, id_proveedor), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult Tab1(string Id_proveedor, int CantidadPactadaMachos, int CantidadPactadaHembras, DateTime FechaProgramada, string id_compra)
        {
            try
            {
                _Compra_Datos CompraDatos = new _Compra_Datos();
                HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);

                return Json(CompraDatos.Tab1(Conexion, ticket.Name, Id_proveedor, CantidadPactadaMachos, CantidadPactadaHembras, FechaProgramada, id_compra, 1));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public JsonResult Upload()
        {
            try
            {
                foreach (string file in Request.Files)
                {
                    var fileContent = Request.Files[file];
                    if (fileContent != null && fileContent.ContentLength > 0)
                    {
                        // get a stream
                        var stream = fileContent.InputStream;

                        byte[] fileData = null;
                        using (var binaryReader = new BinaryReader(stream))
                        {
                            fileData = binaryReader.ReadBytes(fileContent.ContentLength);
                        }

                        string base64 = Convert.ToBase64String(fileData);


                        // and optionally write the file to disk
                        //var fileName = Path.GetFileName(file);
                        //var path = Path.Combine(Server.MapPath("~/App_Data/Images"), fileName);

                        //byte[] imaArray = stream.Re


                        //using (var fileStream = File.Create(path))
                        //{
                        //    stream.CopyTo(fileStream);
                        //}
                    }
                }
            }
            catch (Exception)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("Upload failed");
            }

            return Json("File uploaded successfully");


            //string fileName = Request.Headers["X-File-Name"];
            //string fileType = Request.Headers["X-File-Type"];
            //int fileSize = Convert.ToInt32(Request.Headers["X-File-Size"]);
            ////File's content is available in Request.InputStream property
            //System.IO.Stream fileContent = Request.InputStream;

            ////byte[] buffer = new byte[]

            ////Creating a FileStream to save file's content
            //System.IO.FileStream fileStream = System.IO.File.Create(Server.MapPath("~/") + fileName);
            //fileContent.Seek(0, System.IO.SeekOrigin.Begin);
            ////Copying file's content to FileStream
            //fileContent.CopyTo(fileStream);
            //fileStream.Dispose();
            //return Json("File uploaded");
        }
    }

}
