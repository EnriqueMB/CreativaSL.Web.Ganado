using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CompraModels
    {
        private string _IDCompra;

        public string IDCompra
        {
            get { return _IDCompra; }
            set { _IDCompra = value; }
        }

        private string _IDProveedor;

        public string IDProveedor
        {
            get { return _IDProveedor; }
            set { _IDProveedor = value; }
        }

        private string _IDSucursal;

        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }

        private string _IDFlete;

        public string IDFlete
        {
            get { return _IDFlete; }
            set { _IDFlete = value; }
        }

        private string _IDDocumentoXPagar;

        public string IDDocuentoXPagar
        {
            get { return _IDDocumentoXPagar; }
            set { _IDDocumentoXPagar = value; }
        }

        private string _IDRecepcion;

        public string IDRecepcion
        {
            get { return _IDRecepcion; }
            set { _IDRecepcion = value; }
        }

        private string _GuiaTransito;

        public string GuiaTransito
        {
            get { return _GuiaTransito; }
            set { _GuiaTransito = value; }
        }

        private string _CertZoosanitario;

        public string CertZoosanitario
        {
            get { return _CertZoosanitario; }
            set { _CertZoosanitario = value; }
        }

        private string _CertTuberculosis;

        public string CertTuberculosis
        {
            get { return _CertTuberculosis; }
            set { _CertTuberculosis = value; }
        }

        private string _CertBrucelosis;

        public string CertBrucelosis
        {
            get { return _CertBrucelosis; }
            set { _CertBrucelosis = value; }
        }

        private DateTime _FechaHoraCompra;

        public DateTime FechaHoraCompra
        {
            get { return _FechaHoraCompra; }
            set { _FechaHoraCompra = value; }
        }

        private DateTime _FechaHoraProgramada;

        public DateTime FechaHoraProgramada
        {
            get { return _FechaHoraProgramada; }
            set { _FechaHoraProgramada = value; }
        }

        private int _GanadoPactadoMachos;

        public int GanadoPactadoMachos
        {
            get { return _GanadoPactadoMachos; }
            set { _GanadoPactadoMachos = value; }
        }

        private int _GanadoPactadoHembras;

        public int GanadoPactadoHembras
        {
            get { return _GanadoPactadoHembras; }
            set { _GanadoPactadoHembras = value; }
        }

        private int _GanadoPactadoTotal;

        public int GanadoPactadoTotal
        {
            get { return _GanadoPactadoTotal; }
            set { _GanadoPactadoTotal = value; }
        }

        private decimal _MontoTotal;

        public decimal MontoTotal
        {
            get { return _MontoTotal; }
            set { _MontoTotal = value; }
        }

        private decimal _KilosTotal;

        public decimal KilosTotal
        {
            get { return _KilosTotal; }
            set { _KilosTotal = value; }
        }

        private decimal _MermaPromedio;

        public decimal MermaPromedio
        {
            get { return _MermaPromedio; }
            set { _MermaPromedio = value; }
        }

        private bool _Estatus;

        public bool Estatus
        {
            get { return _Estatus; }
            set { _Estatus = value; }
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