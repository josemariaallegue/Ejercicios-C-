using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Grupo
    {
        public enum TipoManada
        {
            Unica,
            Mixta
        };

        private List<Mascota> mananda;
        private string nombre;
        private TipoManada tipo;

        TipoManada Tipo
        {
            set
            {
                tipo = value;
            }
        }

        private Grupo()
        {
            this.Tipo = TipoManada.Unica;
        }

        private Grupo()
        {
            mananda = new List<Mascota>();
            
        }

        public Grupo (string nombre)
        {
            this.nombre = nombre;
        }

        public Grupo (string nombre, TipoManada tipo)
        {
            this.nombre = nombre;
            this.Tipo = tipo;
        }

        public static bool operator == (Grupo e, Mascota j)
        {
            bool retorno = false;

            if(e.mananda.Contains(j))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Grupo e, Mascota j)
        {
            bool retorno = false;

            if (!(e.mananda.Contains(j)))
            {
                retorno = true;
            }

            return retorno;
        }

        public static Grupo operator +(Grupo e, Mascota j)
        {
            
            if(e == j)
            {
                e.mananda.Remove(j);
            }

            return e;
        }

        public static Grupo operator -(Grupo e,Mascota j)
        {
            if(e != j)
            {
                e.mananda.Add(j);
            }

            return e;
        }

        public static implicit operator string (Grupo e)
        {
            string retorno = 
            

            return retorno;

        }
    }


}