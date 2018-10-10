using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        private string _nombre;
        private string _apellido;
        #endregion

        #region Properties
        public string Nombre
        {
            get { return this._nombre; }
        }

        public string Apellido
        {
            get { return this._apellido; }
        }
        #endregion

        #region Metodos
        protected abstract string FichaTecnica();

        protected virtual string NombreCompleto()
        {
            string formato="";

            formato = string.Format("{0} {1}", this.Nombre, this.Apellido);

            return formato;
        }

        #endregion

        #region Constructor
        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        #endregion

        #region Sobrecargas

        #endregion

    }
}
