using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public sealed class Perro : Mascota
    {
        #region Atributos
        private int _edad;
        private bool _esAlfa;
        #endregion

        #region Properties
        public int Edad
        {
            get { return this._edad; }
            set { this._edad = value; }
        }

        public bool EsAlfa
        {
            get { return this._esAlfa; }
            set { this._esAlfa = value; }
        }
        #endregion

        #region Metodos
        protected sealed override string Ficha()
        {
            string ficha;

            if (this._esAlfa)
            {
                ficha = this.DatosCompletos() + " Status: Alfa de la manada Edad: " + this._edad.ToString();
            }

            else
            {
                ficha = this.DatosCompletos() + " Status: Miembro Edad: " + this._edad.ToString();
            }

            return ficha;
        }
        #endregion

        #region Constructor
        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            this._edad = 0;
            this._esAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool alfa) : this(nombre, raza)
        {
            this._edad = edad;
            this._esAlfa = alfa;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Perro doge, Perro dogi)
        {
            bool goodBoi = false;

            if ((doge.Nombre == dogi.Nombre) && (doge.Raza == dogi.Raza) && (doge.Edad == dogi.Edad))
            {
                goodBoi = true;
            }

            return goodBoi;
        }

        public static bool operator !=(Perro doge, Perro dogi)
        {
            return !(doge==dogi);
        }

        public static explicit operator int(Perro doge)
        {
            return doge.Edad;
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object doge)
        {
            return this == (Perro)doge;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        #endregion
    }
}
