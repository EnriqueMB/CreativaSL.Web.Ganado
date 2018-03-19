using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class FleteModels
    {
        #region Variables
        private string _id_flete;
        private string _id_chofer;
        private string _id_jaula;
        private string _id_vehiculo;
        private decimal _precioFlete;
        private int _kmFinalVehiculo;
        private int _kmInicialVehiculo;
        #endregion
        #region Metodos
        public string id_flete
        {
            get { return _id_flete; }
            set { _id_flete = value; }
        }

        public string id_vehiculo
        {
            get { return _id_vehiculo; }
            set { _id_vehiculo = value; }
        }

        public string id_chofer
        {
            get { return _id_chofer; }
            set { _id_chofer = value; }
        }

        public string id_jaula
        {
            get { return _id_jaula; }
            set { _id_jaula = value; }
        }

        public int kmInicialVehiculo
        {
            get { return _kmInicialVehiculo; }
            set { _kmInicialVehiculo = value; }
        }
        
        public int kmFinalVehiculo
        {
            get { return _kmFinalVehiculo; }
            set { _kmFinalVehiculo = value; }
        }

        [Required]
        [Range(0, 100000)]
        [DisplayName("Precio del flete")]
        public decimal precioFlete
        {
            get { return _precioFlete; }
            set { _precioFlete = value; }
        }
        #endregion
        #region Datos de control
        public string Conexion { get; set; }
        public int Resultado { get; set; }
        public bool Completado { get; set; }
        public string Usuario { get; set; }
        public int Opcion { get; set; }
        #endregion
    }
}