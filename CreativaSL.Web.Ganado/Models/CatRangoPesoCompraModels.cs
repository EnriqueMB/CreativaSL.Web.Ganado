using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CatRangoPesoCompraModels
    {
        private int _IDRango;

        public int IDRango
        {
            get { return _IDRango; }
            set { _IDRango = value; }
        }

        private bool _EsMacho;

        public bool EsMacho
        {
            get { return _EsMacho; }
            set { _EsMacho = value; }
        }

        private decimal _PesoMinimo;

        public decimal PesoMinimo
        {
            get { return _PesoMinimo; }
            set { _PesoMinimo = value; }
        }

        private decimal _PesoMaximo;

        public decimal PesoMaximo
        {
            get { return _PesoMaximo; }
            set { _PesoMaximo = value; }
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