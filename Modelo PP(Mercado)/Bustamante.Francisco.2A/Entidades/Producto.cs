using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    #region Enumerados
    public enum EMarcaProducto
    {
        Manaos,
        Pitusas,
        Naranju,
        Diversion,
        Swift,
        Favorita
    }

    public enum ETipoProducto
    {
        Galletitas,
        Gaseosa,
        Jugo,
        Harina,
        Todos
    }
    #endregion

    public abstract class Producto
    {
        #region Atributos
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;
        #endregion

        #region Properties
        public EMarcaProducto Marca
        {
            get { return this._marca; }

        }

        public float Precio
        {
            get { return this._precio; }
        }

        public float CalcularCostoProduccion
        {
            get;
        }
        #endregion

        #region Metodos

        #endregion

        #region Constructor

        #endregion

        #region Operadores

        #endregion


    }
}
