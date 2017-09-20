using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP_LABII.Clases
{
    abstract class Persona
    { 
        //Atributos
        private string nombre;
        private string apellido;

        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellido
        {
            get { return apellido; }
        }

        abstract protected string FichaTecnica()
        {
            return "";
        }

        virtual protected string NombreCompleto()
        {
            string nombreCompleto = string.Format("{0} {1}", nombre, apellido);
            return nombreCompleto;
        }

        public Persona() { }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
