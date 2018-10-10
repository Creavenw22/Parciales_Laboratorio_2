using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        #region Metodos
        protected override string FichaTecnica()
        {
            return NombreCompleto();
        }
        #endregion

        #region Constructor
        public DirectorTecnico(string nombre, string apellido) : base(nombre, apellido)
        {

        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return this.FichaTecnica();
        }
        #endregion

    }
}
