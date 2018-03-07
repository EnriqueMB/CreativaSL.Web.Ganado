using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CreativaSL.Web.Ganado.Areas.Admin.Models.Compra;
using Microsoft.ApplicationBlocks.Data;
using CreativaSL.Web.Ganado.Models;
using System.Data.SqlClient;

namespace CreativaSL.Web.Ganado.Areas.Admin.Models.Compra
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
                    Ds = SqlHelper.ExecuteDataset(CompraModels.Conexion, "spCSLDB_VENTAS_IndexVentas");
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
                List<CatProveedorModels> lista = new List<CatProveedorModels>();
                CatProveedorModels Proveedor;
                object[] parametros = {  };
                SqlDataReader dr = null;
                dr = SqlHelper.ExecuteReader(Compra.Conexion, "spCSLDB_get_ComboCatTipoUsuario");
                while (dr.Read())
                {
                    Proveedor = new CatProveedorModels();
                    Proveedor.IDProveedor       = dr["id_proveedor"].ToString();
                    Proveedor.NombreRazonSocial = dr["nombreRazonSocial"].ToString();
                    lista.Add(Proveedor);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}