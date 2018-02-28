﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CatClienteModels
    {
        private string _IDCliente;

        public string IDCliente 
        {
            get { return _IDCliente; }
            set { _IDCliente = value; }
        }

        private string _IDSucursal;

        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }

        private string _RFC;

        public string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }

        private string _NombreRazonSocial;

        public string NombreRazonSocial
        {
            get { return _NombreRazonSocial; }
            set { _NombreRazonSocial = value; }
        }

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

        #region Datos De Control
        public string Conexion { get; set; }
        public int Resultado { get; set; }
        public bool Completado { get; set; }
        public string Usuario { get; set; }
        public int Opcion { get; set; }
        #endregion
    }
}