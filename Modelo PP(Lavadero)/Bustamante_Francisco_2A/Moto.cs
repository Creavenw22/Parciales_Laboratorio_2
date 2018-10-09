using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public class Moto : Vehiculo
    {
        #region Atributos
        protected float _cilindrada;
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat(" - Cilindrada: {0.##}", this._cilindrada);

            return sb.ToString();
        }
        #endregion

        #region Constructor
        public Moto(string patente, byte ruedas, EMarcas marca) : base(patente, ruedas, marca)
        {
            this._cilindrada = 125;
        }

        public Moto(string patente, byte ruedas, EMarcas marca, float cilindrada) : this(patente, ruedas, marca)
        {
            this._cilindrada = cilindrada;
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
