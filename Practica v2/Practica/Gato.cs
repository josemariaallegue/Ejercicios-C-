using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza)
        {

        }

        public static bool operator ==(Gato obj1, Gato obj2)
        {
            bool retorno = false;

            if (obj1.Nombre == obj2.Nombre && obj1.Raza == obj2.Raza)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Gato obj1, Gato obj2)
        {
            bool retorno = false;

            if (obj1.Nombre != obj2.Nombre && obj1.Raza != obj2.Raza)
            {
                retorno = true;
            }

            return retorno;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            Gato auxiliar = (Gato)obj;

            if (obj == null)
            {
                retorno = false;
            }
            else if (this == auxiliar)
            {
                retorno = true;
            }

            return retorno;
        }

        public override string ToString()
        {
            string retorno = this.Nombre + " " + this.Raza;

            return retorno;
        }

        protected override string Ficha()
        {
            string retorno = string.Format("{0} {1}", this.Nombre, this.Raza);

            return retorno;
        }

    }
}
