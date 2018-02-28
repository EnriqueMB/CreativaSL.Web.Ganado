using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CatProductosModels
    {
        private string _IDProducto;

        public string IDProducto
        {
            get { return _IDProducto; }
            set { _IDProducto = value; }
        }

        private string _Clave;

        public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }

        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private string _Clave_cfdi;

        public string Clave_cfdi
        {
            get { return _Clave_cfdi; }
            set { _Clave_cfdi = value; }
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