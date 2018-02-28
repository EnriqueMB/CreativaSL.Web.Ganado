using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class ExistenciaProductoAlmacenModels
    {
        private string _id_almacen;

        public string id_almacen
        {
            get { return _id_almacen; }
            set { _id_almacen = value; }
        }
        private string _id_producto;

        public string id_producto
        {
            get { return _id_producto; }
            set { _id_producto = value; }
        }
        private string _id_unidadProducto;

        public string id_unidadProducto
        {
            get { return _id_unidadProducto; }
            set { _id_unidadProducto = value; }
        }
        private decimal _existencia;

        public decimal existencia
        {
            get { return _existencia; }
            set { _existencia = value; }
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