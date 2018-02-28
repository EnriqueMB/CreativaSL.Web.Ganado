using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class GanadoModels
    {
        private string _id_ganado;

        public string id_ganado
        {
            get { return _id_ganado; }
            set { _id_ganado = value; }
        }
        private string _id_sucursal;

        public string id_sucursal
        {
            get { return _id_sucursal; }
            set { _id_sucursal = value; }
        }
        private string _id_estatus_Ganado;

        public string id_estatus_Ganado
        {
            get { return _id_estatus_Ganado; }
            set { _id_estatus_Ganado = value; }
        }
        private int _id_tipoGanadoPorPeso;

        public int id_tipoGanadoPorPeso
        {
            get { return _id_tipoGanadoPorPeso; }
            set { _id_tipoGanadoPorPeso = value; }
        }
        private string _observacion;

        public string observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }
        private string _numArete;

        public string numArete
        {
            get { return _numArete; }
            set { _numArete = value; }
        }
        private bool _ranchoCliente;

        public bool ranchoCliente
        {
            get { return _ranchoCliente; }
            set { _ranchoCliente = value; }
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