using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{ 
    public sealed class Gato : Mascota
    {
        #region Metodos
        protected sealed override string Ficha()
        {
            return this.DatosCompletos();
        }
        #endregion

        #region Constructor
        public Gato(string nombre, string raza) : base(nombre, raza)
        {

        }
        #endregion

        #region Operador
        public static bool operator ==(Gato gatito, Gato gatote)
        {
            bool gatitens = false;

            if ((gatito.Nombre == gatote.Nombre) && (gatito.Raza == gatote.Raza))
            {
                gatitens = true;
            }

            return gatitens;
        }

        public static bool operator !=(Gato gatito, Gato gatote)
        {
            return !(gatito==gatote);
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object gatitens)
        {
            return (this==(Gato)gatitens);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        #endregion


    }
}
