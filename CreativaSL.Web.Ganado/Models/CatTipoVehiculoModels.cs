using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CatTipoVehiculoModels
    {
        private int _IDTipoVehiculo;

        public int IDTipoVehiculo
        {
            get { return _IDTipoVehiculo; }
            set { _IDTipoVehiculo = value; }
        }

        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
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