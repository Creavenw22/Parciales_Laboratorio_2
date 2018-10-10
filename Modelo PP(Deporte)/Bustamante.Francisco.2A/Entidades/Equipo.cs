using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    #region Enumerado
    public enum Deportes
    {
        Basquet,
        Futbol,
        Hadball,
        Rugby
    }
    #endregion

    public class Equipo
    {
        #region Atributos
        private Deportes _deporte;
        private DirectorTecnico _dt;
        private List<Jugador> _jugadores;
        private string _nombre;
        #endregion

        #region Properties
        public Deportes Deporte
        {
            set { this._deporte = value; }
        }
        #endregion

        #region Constructor
        private Equipo()
        {
            this.Deporte = Deportes.Futbol;
            this._jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico dt) : this()
        {
            this._nombre = nombre;
            this._dt = dt;
        }

        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte) : this(nombre, dt)
        {
            this.Deporte = deporte;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Equipo team, Jugador player)
        {
            bool flag = false;

            foreach (Jugador item in team._jugadores)
            {
                if (item==player)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public static bool operator !=(Equipo team, Jugador player)
        {
            return !(team == player);
        }

        public static Equipo operator +(Equipo team, Jugador player)
        {
            if (team != player)
            {
                team._jugadores.Add(player);
            }
            return team;
        }

        public static Equipo operator -(Equipo team, Jugador player)
        {
            if (team == player)
            {
                team._jugadores.Remove(player);
            }
            return team;
        }

        public static implicit operator string(Equipo team)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("**{0} {1}**\n",team._nombre,team._deporte);
            sb.AppendLine("Nomina jugadores:");

            foreach (Jugador item in team._jugadores)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendFormat("Dirigido por: {0}", team._dt.ToString());

            return sb.ToString();
        }
        #endregion

    }
}
