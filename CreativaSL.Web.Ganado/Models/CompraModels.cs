﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CompraModels
    {
        #region Variables
        private DataTable _tablaCompra;
        private DateTime _FechaHoraCompra;
        private DateTime _FechaHoraProgramada;
        private string _IDProveedor;
        private string _IDSucursal;
        private string _IDCompra;
        private string _IDFlete;
        private string _IDDocumentoXPagar;
        private string _IDRecepcion;
        private string _GuiaTransito;
        private string _CertZoosanitario;
        private string _CertTuberculosis;
        private string _CertBrucelosis;
        private int _GanadoPactadoMachos;
        private int _GanadoPactadoHembras;
        private int _GanadoPactadoTotal;
        private decimal _MontoTotal;
        private decimal _KilosTotal;
        private decimal _MermaPromedio;
        private bool _Estatus;
        private HttpPostedFileBase[] _ImgFierros;
        private List<CatProveedorModels> _TablaProveedoresCmb;
        #endregion

        #region Metodos
        [Required(ErrorMessage = "Seleccione una imagen de un fierro, por lo menos.")]
        [Display(Name = "Imganes Fierros")]
        public HttpPostedFileBase[] ImgFierros { get; set; }

        public string IDCompra
        {
            get { return _IDCompra; }
            set { _IDCompra = value; }
        }
        public string IDProveedor
        {
            get { return _IDProveedor; }
            set { _IDProveedor = value; }
        }
        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }
        public string IDFlete
        {
            get { return _IDFlete; }
            set { _IDFlete = value; }
        }
        public string IDDocuentoXPagar
        {
            get { return _IDDocumentoXPagar; }
            set { _IDDocumentoXPagar = value; }
        }
        public string IDRecepcion
        {
            get { return _IDRecepcion; }
            set { _IDRecepcion = value; }
        }
        public string GuiaTransito
        {
            get { return _GuiaTransito; }
            set { _GuiaTransito = value; }
        }
        public string CertZoosanitario
        {
            get { return _CertZoosanitario; }
            set { _CertZoosanitario = value; }
        }
        public string CertTuberculosis
        {
            get { return _CertTuberculosis; }
            set { _CertTuberculosis = value; }
        }
        public string CertBrucelosis
        {
            get { return _CertBrucelosis; }
            set { _CertBrucelosis = value; }
        }
        public DateTime FechaHoraCompra
        {
            get { return _FechaHoraCompra; }
            set { _FechaHoraCompra = value; }
        }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaHoraProgramada
        {
            get { return _FechaHoraProgramada; }
            set { _FechaHoraProgramada = value; }
        }
        public int GanadoPactadoMachos
        {
            get { return _GanadoPactadoMachos; }
            set { _GanadoPactadoMachos = value; }
        }
        public int GanadoPactadoHembras
        {
            get { return _GanadoPactadoHembras; }
            set { _GanadoPactadoHembras = value; }
        }
        public int GanadoPactadoTotal
        {
            get { return _GanadoPactadoTotal; }
            set { _GanadoPactadoTotal = value; }
        }
        public decimal MontoTotal
        {
            get { return _MontoTotal; }
            set { _MontoTotal = value; }
        }
        public decimal KilosTotal
        {
            get { return _KilosTotal; }
            set { _KilosTotal = value; }
        }
        public decimal MermaPromedio
        {
            get { return _MermaPromedio; }
            set { _MermaPromedio = value; }
        }
        public bool Estatus
        {
            get { return _Estatus; }
            set { _Estatus = value; }
        }
        public DataTable TablaCompra
        {
            get { return _tablaCompra; }
            set { _tablaCompra = value; }
        }

        [Required(ErrorMessage = "Tipo de Usuario es un campo requerido")]
        [Display(Name = "Tipo de Usuario")]
        public List<CatProveedorModels> TablaProveedoresCmb
        {
            get { return _TablaProveedoresCmb; }
            set { _TablaProveedoresCmb = value; }
        }
        #endregion 

        #region Datos De Control
        public string Conexion { get; set; }
        public int Resultado { get; set; }
        public bool Completado { get; set; }
        public string Usuario { get; set; }
        public int Opcion { get; set; }
        #endregion
    }
}