using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace CreativaSL.Web.Ganado.Models
{
    public class _Compra_Datos
    {   
        /// <summary>
        /// Obtiene los datos a mostar en el modulo COMPRAS->INDEX
        /// </summary>
        /// <param name="CompraModels"></param>
        /// <returns></returns>
        public CompraModels ObtenerCompraIndex(CompraModels CompraModels)
        {
            try
            {
                DataSet Ds = null;
                Ds = SqlHelper.ExecuteDataset(CompraModels.Conexion, "spCSLDB_COMPRAS_IndexVentas");
                if (Ds != null)
                {
                    if (Ds.Tables.Count > 0)
                    {
                        if (Ds.Tables[0] != null)
                        {
                        CompraModels.TablaCompra = Ds.Tables[0];
                        }
                    }
                }
                return CompraModels;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Obtiene un listado de todos los proveedores dados de alta
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<CatProveedorModels> ObtenerListadoProveedores(CompraModels Compra)
        {
            try
            {
                List<CatProveedorModels> ListaProveedores = new List<CatProveedorModels>();
                CatProveedorModels Proveedor = new CatProveedorModels {
                    IDProveedor = "0",
                    NombreRazonSocial = "SELECCIONE UN PROVEEDOR"
                };
                ListaProveedores.Add(Proveedor);
                SqlDataReader dr = null;
                dr = SqlHelper.ExecuteReader(Compra.Conexion, "spCSLDB_COMPRAS_GetProveedores");
                while (dr.Read())
                {
                    Proveedor = new CatProveedorModels
                    {
                        IDProveedor = dr["id_proveedor"].ToString(),
                        NombreRazonSocial = dr["NombreProveedor"].ToString(),
                    };
                    ListaProveedores.Add(Proveedor);
                }
                return ListaProveedores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Obtiene la imagen del manifiesto del fierro y el número de U.P.P. del proveedor seleccionado
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="IDProveedor"></param>
        /// <returns></returns>
        public List<string> ObtenerDatosProveedorPorID(string conexion, string IDProveedor)
        {
            string Upp = null, ImgManifestacionFierro = null;
            List<string> ListDataProveedor = new List<string>();

            object[] parametros =
            {
                IDProveedor
            };

            SqlDataReader dr = null;
            dr = SqlHelper.ExecuteReader(conexion, "spCSLDB_COMPRAS_GetValuesProveedorByID", parametros);

            while (dr.Read())
            {
                Upp = dr["UPP"].ToString();
                ImgManifestacionFierro = dr["imgManifestacionFierro"].ToString();
            }
            ListDataProveedor.Add(Upp);
            ListDataProveedor.Add(ImgManifestacionFierro);

            return ListDataProveedor;
        }
        /// <summary>
        /// Obtiene un listado de todos los choferes disponibles
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<CatChoferModels> ObtenerListadoChoferes(CompraModels Compra)
        {
            try
            {
                List<CatChoferModels> ListaChoferes = new List<CatChoferModels>();
                CatChoferModels Chofer = new CatChoferModels
                {
                    id_licencia = "0",
                    Nombre = "SELECCIONE UN CHOFER"
                };
                ListaChoferes.Add(Chofer);
                SqlDataReader dr = null;
                dr = SqlHelper.ExecuteReader(Compra.Conexion, "spCSLDB_COMPRAS_getChoferes");
                while (dr.Read())
                {
                    Chofer = new CatChoferModels
                    {
                        id_licencia = dr["id_chofer"].ToString(),
                        Nombre = dr["nombre"].ToString(),
                        ApPaterno = dr["apPaterno"].ToString(),
                        ApMaterno = dr["apMaterno"].ToString()
                    };
                    ListaChoferes.Add(Chofer);
                }
                return ListaChoferes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Obtiene los vehiculos disponibles
        /// </summary>
        /// <param name="CompraModels"></param>
        /// <returns></returns>
        public CompraModels ObtenerVehiculos(CompraModels CompraModels)
        {
            try
            {
                DataSet Ds = null;
                Ds = SqlHelper.ExecuteDataset(CompraModels.Conexion, "spCSLDB_COMPRAS_GetVehiculos");
                if (Ds != null)
                {
                    if (Ds.Tables.Count > 0)
                    {
                        if (Ds.Tables[0] != null)
                        {
                            CompraModels.TablaVehiculos = Ds.Tables[0];
                        }
                    }
                }
                return CompraModels;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene los vehiculos disponibles
        /// </summary>
        /// <param name="CompraModels"></param>
        /// <returns></returns>
        public CompraModels ObtenerLugares(CompraModels CompraModels, int opcion)
        {
            try
            {
                object[] parametros =
                {
                    opcion
                };

                DataSet Ds = null;
                Ds = SqlHelper.ExecuteDataset(CompraModels.Conexion, "spCSLDB_COMPRAS_getLugares", parametros);

                if (Ds != null)
                {
                    if (Ds.Tables.Count > 0)
                    {
                        if (Ds.Tables[0] != null)
                        {
                            CompraModels.TablaLugares = Ds.Tables[0];
                        }
                    }
                }
                return CompraModels;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Tab1(string conexion, string id_usuario, string id_proveedor, int cantidadPactadaMachos, int cantidadPactadaHembras, DateTime fechaProgramada, string id_compra, int tab)
        {
            try
            {
                string idCompra = string.Equals(id_compra, "1") ? "1" : id_compra;

                object[] parametros =
                {
                    tab
                    ,id_proveedor
                    ,id_usuario
                    ,id_compra
                    ,cantidadPactadaMachos
                    ,cantidadPactadaHembras
                    ,fechaProgramada
                };

                SqlDataReader dr = null;
                dr = SqlHelper.ExecuteReader(conexion, "spCSLDB_COMPRAS_FuncionesAjax", parametros);

                while (dr.Read())
                {
                    idCompra = dr["id_compra"].ToString();
                }

                return idCompra;
            }
            catch (Exception ex) 
            {

                throw ex;
            }
        }
    }
}