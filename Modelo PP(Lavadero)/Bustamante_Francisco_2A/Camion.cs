using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public class Camion : Vehiculo
    {
        #region Atributos
        protected float _tara;
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendFormat(" - Tara: {0}", this._tara);

            return sb.ToString();
        }
        #endregion

        #region Constructor
        public Camion(string patente, byte ruedas, EMarcas marca) : base(patente, ruedas, marca)
        {
            this._tara = 5000;
        }

        public Camion(Vehiculo camion ,float tara) : this(camion.Patente, camion.Ruedas,camion.Marca)
        {
            this._tara = tara;
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
