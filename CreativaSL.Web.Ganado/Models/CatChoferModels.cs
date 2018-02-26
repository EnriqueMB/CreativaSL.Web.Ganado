using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data;

namespace CreativaSL.Web.Ganado.Models
{
    public class CatChoferModels
    {
        private string _IDChofer;

        public string IDChofer
        {
            get { return _IDChofer; }
            set { _IDChofer = value; }
        }

        private string _Nombre;
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "nombre")]
        [StringLength(80, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2} y un maximo de {1}.", MinimumLength = 1)]
        [RegularExpression(@"^[A-Za-záéíóúñÁÉÍÓÚÑ\s]*$", ErrorMessage = "Solo Letras")]
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _ApPaterno;
        [Required(ErrorMessage = "El apellido paterno es obligatorio")]
        [Display(Name = "apellido paterno")]
        [StringLength(70, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2} y un maximo de {1}.", MinimumLength = 1)]
        [RegularExpression(@"^[A-Za-záéíóúñÁÉÍÓÚÑ\s]*$", ErrorMessage = "Solo Letras")]
        public string ApPaterno
        {
            get { return _ApPaterno; }
            set { _ApPaterno = value; }
        }

        private string _ApMaterno;
        [Display(Name = "apellido materno")]
        [StringLength(70, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2} y un maximo de {1}.", MinimumLength = 1)]
        [RegularExpression(@"^[A-Za-záéíóúñÁÉÍÓÚÑ\s]*$", ErrorMessage = "Solo Letras")]
        public string ApMaterno
        {
            get { return _ApMaterno; }
            set { _ApMaterno = value; }
        }

        private bool _Licencia;

        public bool Licencia
        {
            get { return _Licencia; }
            set { _Licencia = value; }
        }

        private bool _Estatus;

        public bool Estatus
        {
            get { return _Estatus; }
            set { _Estatus = value; }
        }

        private DataTable _TablaDatos;

        public DataTable TablaDatos
        {
            get { return _TablaDatos; }
            set { _TablaDatos = value; }
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