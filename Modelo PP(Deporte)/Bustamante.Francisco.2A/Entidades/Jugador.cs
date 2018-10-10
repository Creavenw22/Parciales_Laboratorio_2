using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        #region Atributos
        private int _numero;
        private bool _esCapitan;
        #endregion

        #region Properties
        public int Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public bool Capitan
        {
            get { return this._esCapitan; }
            set { this._esCapitan = value; }
        }
        #endregion

        #region Metodos
        protected override string FichaTecnica()
        {
            string formato = "";

            if (this.Capitan)
            {
                formato = string.Format("{0} {1}, Capitan del equipo, Camiseta numero {2}", this.Nombre, this.Apellido, this.Numero);
            }

            else
            {
                formato = string.Format("{0} {1} Camiseta numero {2}", this.Nombre, this.Apellido, this.Numero);
            }

            return formato;
        }
        #endregion

        #region Constructor
        public Jugador(string nombre, string apellido) : base(nombre, apellido)
        {
            this.Capitan = false;
            this.Numero = 0;
        }

        public Jugador(string nombre, string apellido, int numero, bool capitan) : this(nombre, apellido)
        {
            this.Numero = numero;
            this.Capitan = capitan;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool flag = false;

            if ((j1.Nombre==j2.Nombre) && (j1.Apellido==j2.Apellido) && (j1.Numero==j2.Numero))
            {
                flag = true;
            }
            return flag;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public static explicit operator int(Jugador j1)
        {
            return j1.Numero;
        }



        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return FichaTecnica();
        }

        public override bool Equals(object obj)
        {
            return (this == ((Jugador)obj));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
