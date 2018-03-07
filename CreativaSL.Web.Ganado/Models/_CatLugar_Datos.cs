using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class _CatLugar_Datos
    {
        public CatLugarModels AbcCatLugar(CatLugarModels datos)
        {
            try
            {
                object[] parametros =
                {
                   datos.opcion,datos.id_lugar,datos.descripcion,datos.longitud,datos.latitud,datos.user
                    };
                object aux = SqlHelper.ExecuteScalar(datos.conexion, "spCSLDB_abc_CatLugar", parametros);
                datos.id_lugar = aux.ToString();
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<CatLugarModels> obtenerCatLugar(CatLugarModels Datos)
        {
            try
            {
                List<CatLugarModels> lista = new List<CatLugarModels>();
                CatLugarModels item;
                SqlDataReader dr = null;
                dr = SqlHelper.ExecuteReader(Datos.conexion, "EM_spCSLDB_get_Lugar");
                while (dr.Read())
                {
                    item = new CatLugarModels();
                    item.id_lugar = dr["IDLugar"].ToString();
                    item.descripcion = dr["descripcion"].ToString();
                    item.latitud = Convert.ToSingle(dr["latitud"].ToString());
                    item.longitud = Convert.ToSingle(dr["longitud"].ToString());
                    lista.Add(item);
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