using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    #region Enumerado
        public enum EMarcas
        {
            Honda,
            Ford,
            Zanella,
            Scania,
            Iveco,
            Fiat,
            NONE
        }
        #endregion

    public class Vehiculo
    {
        

        #region Atributos
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarcas _marca;
        #endregion

        #region Properties

        public string Patente
        {
            get { return this._patente; }
        }

        public byte Ruedas
        {
            get { return this._cantRuedas; }
            set { this._cantRuedas = value; }
        }

        public EMarcas Marca
        {
            get { return this._marca; }
        }
        #endregion

        #region Metodos
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Patente: {0} - Ruedas {1} - Marca: {2}",this._patente,this._cantRuedas,this.Marca);

            return sb.ToString();
        }

        #endregion

        #region Constructor
        public Vehiculo(string patente,byte ruedas,EMarcas marca)
        {
            this._patente = patente;
            this._cantRuedas = ruedas;
            this._marca = marca;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool esIgual = false;

            if ((v1._patente == v2._patente) && (v1.Marca == v2.Marca))
            {
                esIgual = true;
            }
            return esIgual;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
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
