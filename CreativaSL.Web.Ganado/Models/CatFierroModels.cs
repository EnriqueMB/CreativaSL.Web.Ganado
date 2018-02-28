using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CatFierroModels
    {
        private string _IDFierro;

        public string IDFierro
        {
            get { return _IDFierro; }
            set { _IDFierro = value; }
        }

        private string _NombreFierro;

        public string NombreFierro
        {
            get { return _NombreFierro; }
            set { _NombreFierro = value; }
        }

        private string _ImgFierro;

        public string ImgFierro
        {
            get { return _ImgFierro; }
            set { _ImgFierro = value; }
        }

        private string _Observaciones;

        public string Observaciones
        {
            get { return _Observaciones; }
            set { _Observaciones = value; }
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