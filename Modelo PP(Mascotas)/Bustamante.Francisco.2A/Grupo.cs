using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public class Grupo
    {
        #region Enumerado
        public enum TipoManada
        {
            Unica,
            Mixta
        }
        #endregion

        #region Atributos
        private List<Mascota> _manada;
        private string _nombre;
        private TipoManada _tipo;
        #endregion

        #region Properties
        public TipoManada Tipo
        {
            set { this._tipo = value; }
        }
        #endregion

        #region Metodos

        #endregion

        #region Constructor
        public Grupo()
        {
            this._manada = new List<Mascota>();
            this._tipo = TipoManada.Unica;
        }

        public Grupo(string nombre)
        {
            this._nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo) : this(nombre)
        {
            this.Tipo = tipo;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Grupo manada, Mascota pichicho)
        {
            bool belongs = false;

            if (manada._manada != null)
            {
                foreach (Mascota item in manada._manada)
                {
                    if (item == pichicho)
                    {
                        belongs = true;
                        break;
                    }
                }
            }
            return belongs;
        }

        public static bool operator !=(Grupo manada, Mascota pichicho)
        {
            return !(manada == pichicho);
        }

        public static Grupo operator +(Grupo manada, Mascota pichicho)
        {
            if (manada._manada != null)
            {
                if (manada != pichicho)
                {
                    manada._manada.Add(pichicho);
                }
            }
            return manada;
        }

        public static Grupo operator -(Grupo manada, Mascota pichicho)
        {
            if (manada._manada != null)
            {
                if (manada == pichicho)
                {
                    manada._manada.Remove(pichicho);
                }
            }
            return manada;
        }

        public static explicit operator string(Grupo manada)
        {
            StringBuilder pandilla = new StringBuilder();
            pandilla.AppendFormat("**{0} {1}**",manada._nombre,manada._tipo);

            pandilla.AppendLine("Integrantes: ");
            

            foreach (Mascota item in manada._manada)
            {
                pandilla.AppendLine(item.ToString());
            }

            return pandilla.ToString();
        }

        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return (this==(Mascota)obj);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        #endregion


    }
}
