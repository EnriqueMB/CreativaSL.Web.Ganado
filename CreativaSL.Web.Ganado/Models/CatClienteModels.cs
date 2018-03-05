using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CatClienteModels
    {
        public CatClienteModels()
        {
            _IDCliente = string.Empty;
            _IDSucursal = string.Empty;
            _RFC = string.Empty;
            _NombreRazonSocial = string.Empty;
            _IDRegimenFiscal = string.Empty;
            _ListaClientes = new List<CatClienteModels>();
            Conexion = string.Empty;
            Usuario = string.Empty;
            _NombreSucursal = string.Empty;
            _NombreRegimenFiscal = string.Empty;
            _ListaCmbSucursal = new List<CatSucursalesModels>();
            _ListaRegimenCMB = new List<CFDI_RegimenFiscalModels>();
        }

        /// <summary>
        /// El identificador de el cliente
        /// </summary>
        private string _IDCliente;

        public string IDCliente 
        {
            get { return _IDCliente; }
            set { _IDCliente = value; }
        }
        /// <summary>
        /// El identificador por sucursar
        /// </summary>
        private string _IDSucursal;

        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }
        /// <summary>
        /// EL Registro Federal de Contribuyentes
        /// </summary>
        private string _RFC;

        public string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }
        /// <summary>
        /// El nombre con el que se le conoces a una Empresa
        /// </summary>
        private string _NombreRazonSocial;

        public string NombreRazonSocial
        {
            get { return _NombreRazonSocial; }
            set { _NombreRazonSocial = value; }
        }
        /// <summary>
        /// Si es persona fisica ó si Empresa
        /// </summary>
        private bool _EsPersonaFisica;

        public bool EsPersonaFisica
        {
            get { return _EsPersonaFisica; }
            set { _EsPersonaFisica = value; }
        }

        private string _IDRegimenFiscal;

        public string IDRegimenFiscal
        {
            get { return _IDRegimenFiscal; }
            set { _IDRegimenFiscal = value; }
        }

        private List<CatClienteModels> _ListaClientes;

        public List<CatClienteModels> ListaClientes
        {
            get { return _ListaClientes; }
            set { _ListaClientes = value; }
        }

        private List<CatSucursalesModels> _ListaCmbSucursal;

        public List<CatSucursalesModels> ListaCmbSucursal
        {
            get { return _ListaCmbSucursal; }
            set { _ListaCmbSucursal = value; }
        }

        private List<CFDI_RegimenFiscalModels> _ListaRegimenCMB;

        public List<CFDI_RegimenFiscalModels> ListaRegimenCMB
        {
            get { return _ListaRegimenCMB; }
            set { _ListaRegimenCMB = value; }
        }


        private string _NombreSucursal;

        public string NombreSucursal
        {
            get { return _NombreSucursal; }
            set { _NombreSucursal = value; }
        }

        private string _NombreRegimenFiscal;

        public string NombreRegimenFiscal
        {
            get { return _NombreRegimenFiscal; }
            set { _NombreRegimenFiscal = value; }
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