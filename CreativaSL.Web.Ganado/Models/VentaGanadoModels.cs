using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class VentaGanadoModels
    {
        private string _id_ganado;

        public string id_ganado
        {
            get { return _id_ganado; }
            set { _id_ganado = value; }
        }
        private string _id_venta;

        public string id_venta
        {
            get { return _id_venta; }
            set { _id_venta = value; }
        }

        #region Datos De Control
        public string Conexion { get; set; }
        public int Resultado { get; set; }
        public bool Completado { get; set; }
        public string Usuario { get; set; }
        public int Opcion { get; set; }
        #endregion
    }
}