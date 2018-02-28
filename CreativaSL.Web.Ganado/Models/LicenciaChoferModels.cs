using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class LicenciaChoferModels
    {
        private string _id_licencia;

        public string id_licencia
        {
            get { return _id_licencia; }
            set { _id_licencia = value; }
        }
        private string _id_chofer;

        public string id_chofer
        {
            get { return _id_chofer; }
            set { _id_chofer = value; }
        }
        private string _numLicencia;

        public string numLicencia
        {
            get { return _numLicencia; }
            set { _numLicencia = value; }
        }
        private DateTime _vigencia;

        public DateTime vigencia
        {
            get { return _vigencia; }
            set { _vigencia = value; }
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