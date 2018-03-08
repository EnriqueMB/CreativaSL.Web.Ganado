using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CatAlmacenModels
    {

        /// <summary>
        /// Inicializar los datos
        /// </summary>
        public CatAlmacenModels()
        {
            this._IDAlmacen = string.Empty;
            this._ClaveAlmacen = string.Empty;
            this._IDSucursal = string.Empty;
            this._NombreSucursal = string.Empty;
            this._Descripcion = string.Empty;
            this._ListaSucursales = new List<CatSucursalesModels>();
            this._ListaAlmacen = new List<CatAlmacenModels>();
            this.Conexion = string.Empty;
            this.Resultado = 0;
            this.Completado = false;
            this.Usuario = string.Empty;
            this.Opcion = 0;
        }


        /// <summary>
        /// Identificador primario del almacén
        /// </summary>
        private string _IDAlmacen;
        public string IDAlmacen
        {
            get { return _IDAlmacen; }
            set { _IDAlmacen = value; }
        }

        /// <summary>
        /// Identificador interno del almacén
        /// </summary>
        private string _ClaveAlmacen;
        public string ClaveAlmacen
        {
            get { return _ClaveAlmacen; }
            set { _ClaveAlmacen = value; }
        }

        /// <summary>
        /// Identificador de la sucursal a la que pertenece el almacén
        /// </summary>
        private string _IDSucursal;
        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }

        /// <summary>
        /// Nombre de la sucursal a la que pertenece el almacén
        /// </summary>
        private string _NombreSucursal;
        public string NombreSucursal
        {
            get { return _NombreSucursal; }
            set { _NombreSucursal = value; }
        }

        /// <summary>
        /// Descripción del almacen 
        /// </summary>
        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        /// <summary>
        /// Lista de sucursales para llenado de combo Sucursales
        /// </summary>
        private List<CatSucursalesModels> _ListaSucursales;
        public List<CatSucursalesModels> ListaSucursales
        {
            get { return _ListaSucursales; }
            set { _ListaSucursales = value; }
        }

        /// <summary>
        /// Lista de almacenes a dibujar en la tabla principal
        /// </summary>
        private List<CatAlmacenModels> _ListaAlmacen;
        public List<CatAlmacenModels> ListaAlmacen
        {
            get { return _ListaAlmacen; }
            set { _ListaAlmacen = value; }
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