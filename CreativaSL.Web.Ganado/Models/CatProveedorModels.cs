using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.Web.Ganado.Models
{
    public class CatProveedorModels
    {
        private string _IDProveedor;

        public string IDProveedor
        {
            get { return _IDProveedor; }
            set { _IDProveedor = value; }
        }

        private int _IDTipoProveedor;

        public int IDTipoProveedor
        {
            get { return _IDTipoProveedor; }
            set { _IDTipoProveedor = value; }
        }

        private string _IDSucursal;

        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }

        private string _NombreRazonSocial;

        public string NombreRazonSocial
        {
            get { return _NombreRazonSocial; }
            set { _NombreRazonSocial = value; }
        }

        private string _RFC;

        public string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }

        private string _ImgINE;

        public string ImgINE
        {
            get { return _ImgINE; }
            set { _ImgINE = value; }
        }

        private string _ImgManifestacionFierro;

        public string ImgManifestacionFierro
        {
            get { return _ImgManifestacionFierro; }
            set { _ImgManifestacionFierro = value; }
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