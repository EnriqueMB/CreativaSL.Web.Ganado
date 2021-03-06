﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CatLugarModels
    {
        public CatLugarModels() {
            _id_estadoCodigo = string.Empty;
            _id_municipio = 0;
            _id_pais = string.Empty;
            _id_estado = 0;
            _ejido = string.Empty;
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
        //LISTA DE PAISES, ESTADOS Y MUNICIPIOS
        private List<CatPaisModels> _listaPaises;
        [Required(ErrorMessage = "El País es obligatorio")]
        [Display(Name = "Pais")]
        
        
        public List<CatPaisModels> listaPaises
        {
            get { return _listaPaises; }
            set { _listaPaises = value; }
        }
        private List<CatEstadoModels> _listaEstado;
        [Required(ErrorMessage = "El Estado es obligatorio")]
        [Display(Name = "Estado")]
        
        public List<CatEstadoModels> listaEstado
        {
            get { return _listaEstado; }
            set { _listaEstado = value; }
        }
        private List<CatMunicipioModels> _listaMunicipio;
        [Required(ErrorMessage = "El Municipio es obligatorio")]
        [Display(Name = "Municipio")]

        [RegularExpression(@"^[1-9][0-9]*$", ErrorMessage = "Seleccione un municipio")]
        public List<CatMunicipioModels> listaMunicipio
        {
            get { return _listaMunicipio; }
            set { _listaMunicipio = value; }
        }

        //PAIS, ESTADO, MUNICIPIO Y EJIDO DEL LUGAR
        private int _id_municipio;

        public int id_municipio
        {
            get { return _id_municipio; }
            set { _id_municipio = value; }
        }
        private string _id_estadoCodigo;

        public string id_estadoCodigo
        {
            get { return _id_estadoCodigo; }
            set { _id_estadoCodigo = value; }
        }

        private int _id_estado;

        public int id_estado
        {
            get { return _id_estado; }
            set { _id_estado = value; }
        }
        private string _id_pais;

        public string id_pais
        {
            get { return _id_pais; }
            set { _id_pais = value; }
        }
        private string _ejido;
        [Required(ErrorMessage = "El Ejido es obligatorio")]
        [Display(Name = "Pais")]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2} y un maximo de {1}.", MinimumLength = 1)]
        public string ejido
        {
            get { return _ejido; }
            set { _ejido = value; }
        }

        //lista de lugares
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
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "nombre")]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2} y un maximo de {1}.", MinimumLength = 1)]
        [RegularExpression(@"^[A-Za-záéíóúñÁÉÍÓÚÑ\s]*$", ErrorMessage = "Solo Letras")]
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
        private string _lat;

        public string lat
        {
            get { return _lat; }
            set { _lat = value; }
        }

        /// <summary>
        /// COORDENADA DEL LUGAR: LONGITUD
        /// </summary>
        /// 
        private float  _longitud;

        public float longitud
        {
            get { return _longitud; }
            set { _longitud = value; }
        }
        private string _lng;

        public string lng
        {
            get { return _lng; }
            set { _lng = value; }
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