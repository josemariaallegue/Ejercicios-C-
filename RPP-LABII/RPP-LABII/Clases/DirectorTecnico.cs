using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP_LABII.Clases
{
    class DirectorTecnico : Persona
    {
        public DirectorTecnico(string nombre, string apellido):base(nombre,apellido)
        {
           
        }

        private string FichaTecnica()
        {
            return base.NombreCompleto();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
