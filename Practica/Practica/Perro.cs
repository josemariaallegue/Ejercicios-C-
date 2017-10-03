using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Perro:Mascota
    {
        private int edad;
        private bool esAlfa;

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public bool EsAlfa
        {
            get
            {
                return esAlfa;
            }

            set
            {
                esAlfa = value;
            }
        }

        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            this.Edad = 0;
            this.EsAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this.Edad = edad;
            this.EsAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            string retorno;

            if(this.EsAlfa == true)
            {
                retorno = string.Format("{0} {1}, alfa de la manada, edad {3}", this.Nombre, this.Raza, this.Edad);
            }
            else
            {
                retorno = string.Format("{0} {1} edad {3}", this.Nombre, this.Raza, this.Edad);
            }

            return retorno;
        }


        public static bool operator == (Perro j1, Perro j2)
        {
            bool retorno = false;

            if(j1.Edad == j2.Edad && j1.Nombre == j2.Nombre && j1.Raza == j2.Raza)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (Perro j1, Perro j2)
        {
            bool retorno = false;

            if (j1.Edad != j2.Edad && j1.Nombre != j2.Nombre && j1.Raza != j2.Raza)
            {
                retorno = true;
            }

            return retorno;
        }

        public override string ToString()
        {
            string retorno = this.Nombre + " " + this.Raza + "es alfa? " + this.EsAlfa + " y tiene " + this.Edad + " años.";

            return retorno;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            Perro auxiliar = (Perro)obj;

            if(obj == null)
            {
                retorno = false;
            }
            else if(auxiliar == this)
            {
                retorno = true;
            }

            return retorno;
        }

        public static explicit operator int (Perro perro)
        {
            return perro.Edad;
        }
    }
}
