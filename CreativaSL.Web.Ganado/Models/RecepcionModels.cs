using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class RecepcionModels
    {
        private string _id_recepcion;

        public string id_recepcion
        {
            get { return _id_recepcion; }
            set { _id_recepcion = value; }
        }
        private decimal _kiloTotalRecibido;

        public decimal kiloTotalRecibido
        {
            get { return _kiloTotalRecibido; }
            set { _kiloTotalRecibido = value; }
        }
        private int _ganadoTotal;

        public int ganadoTotal
        {
            get { return _ganadoTotal; }
            set { _ganadoTotal = value; }
        }
        private int _ganadoMachos;

        public int ganadoMachos
        {
            get { return _ganadoMachos; }
            set { _ganadoMachos = value; }
        }
        private int _ganadoHembras;

        public int ganadoHembras
        {
            get { return _ganadoHembras; }
            set { _ganadoHembras = value; }
        }
        private DateTime _fechaHoraLlegada;

        public DateTime fechaHoraLlegada
        {
            get { return _fechaHoraLlegada; }
            set { _fechaHoraLlegada = value; }
        }
        private string _recibidoPor;

        public string recibidoPor
        {
            get { return _recibidoPor; }
            set { _recibidoPor = value; }
        }
        private string _observacion;

        public string observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }

    }
}