using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class VentaModels
    {
        private string _id_venta;

        public string id_venta
        {
            get { return _id_venta; }
            set { _id_venta = value; }
        }
        private string _id_cliente;

        public string id_cliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }
        }
        private string _id_flete;

        public string id_flete
        {
            get { return _id_flete; }
            set { _id_flete = value; }
        }
        private string _documentoXcobrar;

        public string documentoXcobrar
        {
            get { return _documentoXcobrar; }
            set { _documentoXcobrar = value; }
        }
        private string _id_recepcion;

        public string id_recepcion
        {
            get { return _id_recepcion; }
            set { _id_recepcion = value; }
        }
        private decimal _montoTotal;

        public decimal montoTotal
        {
            get { return _montoTotal; }
            set { _montoTotal = value; }
        }
        private DateTime _fechaHoraVenta;

        public DateTime fechaHoraVenta
        {
            get { return _fechaHoraVenta; }
            set { _fechaHoraVenta = value; }
        }
        private DateTime _fechaHoraEmbarque;

        public DateTime fechaHoraEmbarque
        {
            get { return _fechaHoraEmbarque; }
            set { _fechaHoraEmbarque = value; }
        }
        private DateTime _fechaHoraSalida;

        public DateTime fechaHoraSalida
        {
            get { return _fechaHoraSalida; }
            set { _fechaHoraSalida = value; }
        }
        private string _guiaTransito;

        public string guiaTransito
        {
            get { return _guiaTransito; }
            set { _guiaTransito = value; }
        }
        private decimal _pesoTotalEnviado;

        public decimal pesoTotalEnviado
        {
            get { return _pesoTotalEnviado; }
            set { _pesoTotalEnviado = value; }
        }
        private string _certZooSanitario;

        public string certZooSanitario
        {
            get { return _certZooSanitario; }
            set { _certZooSanitario = value; }
        }
        private string _certTuberculosis;

        public string certTuberculosis
        {
            get { return _certTuberculosis; }
            set { _certTuberculosis = value; }
        }
        private string _certBrucelosis;

        public string certBrucelosis
        {
            get { return _certBrucelosis; }
            set { _certBrucelosis = value; }
        }
        private string _numFactura;

        public string numFactura
        {
            get { return _numFactura; }
            set { _numFactura = value; }
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