using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CatLugarModels
    {
        private string _id_lugar;

        public string id_lugar
        {
            get { return _id_lugar; }
            set { _id_lugar = value; }
        }
        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private float _latitud;

        public float latitud
        {
            get { return _latitud; }
            set { _latitud = value; }
        }
        private float  _longitud;

        public float longitud
        {
            get { return _longitud; }
            set { _longitud = value; }
        }
        #region Datos de control
        public bool activo { get; set; }
        public string user { get; set; }
        public string conexion { get; set; }
        public string resultado { get; set; }
        public int opcion { get; set; }
        #endregion
    }
}