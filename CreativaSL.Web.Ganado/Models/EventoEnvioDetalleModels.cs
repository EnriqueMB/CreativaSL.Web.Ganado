using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class EventoEnvioDetalleModels
    {
        private string _IDEventoDetall;

        public string IDEventoDetalle
        {
            get { return _IDEventoDetall; }
            set { _IDEventoDetall = value; }
        }

        private string _IDEvento;

        public string IDEvento
        {
            get { return _IDEvento; }
            set { _IDEvento = value; }
        }

        private string _IDGanado;

        public string IDGanado
        {
            get { return _IDGanado; }
            set { _IDGanado = value; }
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