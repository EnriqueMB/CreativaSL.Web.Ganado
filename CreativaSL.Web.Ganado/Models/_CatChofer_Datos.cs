using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CatChofer_Datos
    {
        public CatChoferModels AbcCatChofer(CatChoferModels datos)
        {
            try
            {
                object[] parametros =
                {
                    datos.Opcion, datos.IDChofer, datos.Nombre, datos.ApPaterno, datos.ApMaterno, datos.Usuario
                };
                object aux = SqlHelper.ExecuteScalar(datos.Conexion, "EM_spCSLDB_abc_Chofer", parametros);
                datos.IDChofer = aux.ToString();
                if (!string.IsNullOrEmpty(datos.IDChofer))
                {
                    datos.Completado = true;
                }
                else
                {
                    datos.Completado = false;
                }
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CatChoferModels ObtenerCatChofer(CatChoferModels Datos)
        {
            try
            {
                DataSet ds = null;
                ds = SqlHelper.ExecuteDataset(Datos.Conexion, "EM_spCSLDB_get_Chofer");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            Datos.TablaDatos = ds.Tables[0];
                        }
                    }
                }
                return Datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CatChoferModels ObtenerDetalleCatChofer(CatChoferModels datos)
        {
            try
            {
                object[] parametros = { datos.IDChofer };
                SqlDataReader dr = null;
                dr = SqlHelper.ExecuteReader(datos.Conexion, "EM_spCSLDB_get_ChoferXID", parametros);
                while (dr.Read())
                {
                    datos.IDChofer = dr["IDChofer"].ToString();
                    datos.ApPaterno = dr["ApPaterno"].ToString();
                    datos.ApMaterno = dr["ApMaterno"].ToString();
                    datos.Licencia = dr.GetBoolean(dr.GetOrdinal("Licencia"));
                }
                return datos;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}