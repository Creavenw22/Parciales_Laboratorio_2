using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public class Auto : Vehiculo
    {
        #region Atributos
        protected int _cantAsientos;
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat(" - Cantidad de Asientos: {0}", this._cantAsientos);
            
            return sb.ToString();
        }
        #endregion

        #region Constructor
        public Auto(string patente,byte ruedas,EMarcas marca) : base (patente,ruedas,marca)
        {
            this._cantAsientos = 5;
        }

        public Auto(string patente,EMarcas marca, int asientos) : this (patente,4,marca)
        {
            this._cantAsientos = asientos;
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
