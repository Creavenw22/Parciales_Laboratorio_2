using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public abstract class Mascota
    {
        #region Atributos
        private string _nombre;
        private string _raza;
        #endregion

        #region Properties
        public string Nombre
        {
            get { return this._nombre; }
        }

        public string Raza
        {
            get { return this._raza; }
        }
        #endregion

        #region Metodos
        abstract protected string Ficha();

        virtual protected string DatosCompletos()
        {
            string formato = "Nombre: {0} Raza: {1}";
            string datos;

            datos = string.Format(formato, this.Nombre, this.Raza);

            return datos;
        }
        #endregion

        #region Constructor
        public Mascota(string nombre, string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }
        #endregion

        #region Sobrecargas

        #endregion
    }
}
