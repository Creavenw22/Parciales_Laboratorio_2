using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public enum EVehiculo
    {
        Auto,
        Camion,
        Moto
    }

    public class Lavadero
    {
        #region Atributos
        private List<Vehiculo> _vehiculos;
        private static float _precioAuto;
        private static float _precioCamion;
        private static float _precioMoto;
        private string _razonSocial;
        #endregion

        #region Properties
        public string LavaderoToString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("**Lavadero {0}**",_razonSocial);
                sb.AppendLine();
                sb.AppendFormat("Razon social: {0}", _razonSocial);
                sb.AppendLine("Precios vigentes: ");
                sb.AppendLine();
                sb.AppendFormat("Precio auto: {0}", _precioAuto);
                sb.AppendLine();
                sb.AppendFormat("Precio camion: {0}", _precioCamion);
                sb.AppendLine();
                sb.AppendFormat("Precio Moto: {0}", _precioMoto);
                sb.AppendLine();
                sb.AppendLine(this.Vehiculos);

                return sb.ToString();
            }
        }

        public string Vehiculos
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                foreach (Vehiculo item in this._vehiculos)
                {
                    sb.AppendLine(item.ToString());
                }
                
                return sb.ToString();
            }
        }

        
        #endregion

        #region Metodos
        public double MostrarTotalFacturado()
        {
            double ganancia = 0;

            ganancia += this.MostrarTotalFacturado(EVehiculo.Auto);
            ganancia += this.MostrarTotalFacturado(EVehiculo.Camion);
            ganancia += this.MostrarTotalFacturado(EVehiculo.Moto);

            return ganancia;
        }

        public double MostrarTotalFacturado(EVehiculo tipoVehiculo)
        {
            double ganancia = 0;

            foreach (Vehiculo item in this._vehiculos)
            {
                switch (tipoVehiculo)
                {
                    case EVehiculo.Auto:
                        if (item is Auto)
                        {
                            ganancia += _precioAuto;
                        }
                        break;

                    case EVehiculo.Camion:
                        if (item is Camion)
                        {
                            ganancia += _precioCamion;
                        }
                        break;

                    case EVehiculo.Moto:
                        if (item is Moto)
                        {
                            ganancia += _precioMoto;
                        }
                        break;

                    default:

                        break;
                }
            }

            return ganancia;
        }
        #endregion

        #region Constructor
        static Lavadero()
        {
            Random num = new Random();

            do
            {
                _precioAuto = num.Next(150, 565);
                _precioCamion = num.Next(150, 565);
                _precioMoto = num.Next(150, 565);
            } while ((_precioAuto != _precioCamion) && (_precioAuto != _precioMoto)&&(_precioCamion!=_precioMoto));
        }

        private Lavadero()
        {
            _vehiculos = new List<Vehiculo>(); 
        }

        public Lavadero(string nombre) : this()
        {
            this._razonSocial = nombre;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Lavadero lava, Vehiculo veh)
        {
            bool flag = false;

            foreach (Vehiculo item in lava._vehiculos)
            {
                if (item == veh)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public static bool operator !=(Lavadero lava, Vehiculo veh)
        {
            return !(lava == veh);
        }

        public static int operator ==(Vehiculo veh, Lavadero lava)
        {
            int index = -1;

            foreach (Vehiculo item in lava._vehiculos)
            {
                if (veh==item)
                {
                    index=lava._vehiculos.IndexOf(item);
                    break;
                }
            }

            return index;
        }

        public static int operator !=(Vehiculo veh, Lavadero lava)
        {
            return (veh == lava);
        }

        public static Lavadero operator +(Lavadero lava,Vehiculo veh)
        {
            if(lava!=veh)
            {
                lava._vehiculos.Add(veh);
            }

            return lava;
        }

        public static Lavadero operator -(Lavadero lava, Vehiculo veh)
        {
            if (lava == veh)
            {
                lava._vehiculos.Remove(veh);
            }

            return lava;
        }
        #endregion
    }
}
