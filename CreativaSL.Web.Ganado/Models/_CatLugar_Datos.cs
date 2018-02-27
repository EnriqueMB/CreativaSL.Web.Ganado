using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
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
    }
}