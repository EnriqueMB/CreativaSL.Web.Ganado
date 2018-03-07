using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CatLugarModels
    {
        public CatLugarModels() {
            _id_lugar = string.Empty;
            _descripcion = string.Empty;
            _latitud = 0;
            _longitud = 0;
            //Datos de control
            activo = false;
            user = string.Empty;
            conexion = string.Empty;
            Completado = false;
            opcion = 0;
            resultado = string.Empty;

        }
        private List<CatLugarModels> _listaLugares;

        public List<CatLugarModels> listaLugares
        {
            get { return _listaLugares; }
            set { _listaLugares = value; }
        }

        /// <summary>
        /// ID DEL LUGAR 
        /// </summary>
        private string _id_lugar;

        public string id_lugar
        {
            get { return _id_lugar; }
            set { _id_lugar = value; }
        }
        /// <summary>
        /// DESCRIPCION DEL LUGAR 
        /// </summary>
        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        /// <summary>
        /// COORDENADA DEL LUGAR : LATITUD
        /// </summary>
        private float _latitud;

        public float latitud
        {
            get { return _latitud; }
            set { _latitud = value; }
        }
        /// <summary>
        /// COORDENADA DEL LUGAR: LONGITUD
        /// </summary>
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
        public bool Completado { get; set; }
        #endregion
    }
}