using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Grupo
    {
        enum TipoManada
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

        public Grupo()
        {

        }

    }

}