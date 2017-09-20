using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP_LABII.Clases
{
    public class Jugador : Persona
    {
        private bool esCapitan;
        private int numero;

        public bool EsCapitan
        {
            get
            {
                return esCapitan;
            }
            set
            {
                esCapitan = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        public Jugador(string nombre, string apellido) 
        {
            

        }

        public Jugador(string nombre, string apellido, bool esCapitan, int numero)
        {
            this.esCapitan = esCapitan;
        }
    }
}
