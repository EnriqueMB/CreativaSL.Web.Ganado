using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CatSucursalesModels
    {
        private string _IDSucursal;

        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }

        private string _IDLugar;

        public string IDLugar
        {
            get { return _IDLugar; }
            set { _IDLugar = value; }
        }

        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
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