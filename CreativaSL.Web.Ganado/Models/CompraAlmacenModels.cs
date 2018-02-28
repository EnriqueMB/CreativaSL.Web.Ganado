using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CompraAlmacenModels
    {
        private string _IDCompraAlmacen;

        public string IDCompraAlmacen
        {
            get { return _IDCompraAlmacen; }
            set { _IDCompraAlmacen = value; }
        }

        private string _IDSucursal;

        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }

        private string _IDProveedorAlmacen;

        public string IDProveedorAlmacen
        {
            get { return _IDProveedorAlmacen; }
            set { _IDProveedorAlmacen = value; }
        }

        private string _NumFacturaNota;

        public string NumFacturaNota
        {
            get { return _NumFacturaNota; }
            set { _NumFacturaNota = value; }
        }

        private decimal _MontoTotal;

        public decimal MontoTotal
        {
            get { return _MontoTotal; }
            set { _MontoTotal = value; }
        }

        private int _IDEstatusCompra;

        public int IDEstatusCompra
        {
            get { return _IDEstatusCompra; }
            set { _IDEstatusCompra = value; }
        }

        private string _IDDocumentoXPagar;

        public string IDDocumentoXPagar
        {
            get { return _IDDocumentoXPagar; }
            set { _IDDocumentoXPagar = value; }
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