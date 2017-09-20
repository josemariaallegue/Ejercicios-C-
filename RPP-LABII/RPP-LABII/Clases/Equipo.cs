using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP_LABII.Clases
{
    class Equipo
    {
        private Deportes deporte;
        private DirectorTecnico dt;
        private List<Jugador> jugadores;
        private string nombre;

        public enum Deportes
        {
            Basquet=0,
            Futbol,
            Handball,
            Rugby
        }

        public Deportes Deporte
        {
            set
            {
                this.deporte = value;
            }
        }

        public Equipo()
        {
            this.deporte = Deportes.Futbol;
        }

        private Equipo()
        {
            List<Jugador> jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico dt)
        {
            this.nombre = nombre;
            this.dt = dt;
        }

        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte)
        {
            this.nombre = nombre;
            this.dt = dt;
            this.deporte = deporte;
        }

        public static bool operator != (Equipo e, Jugador j)
        {
            bool flag = e.jugadores.Any(r => r.Nombre = j.Nombre);


        }
    }
}
