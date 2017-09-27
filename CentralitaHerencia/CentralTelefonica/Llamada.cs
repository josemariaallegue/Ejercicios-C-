using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Llamada
    {

        enum TipoLlamad
        {
            Local,
            Provincial,
            Todas,

        };

        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        public Llamada()
        { 

        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
            
        }

        public string Mostrar()
        {

            StringBuilder texto = new StringBuilder();

            texto.Append("La duracion es: ");
            texto.Append(this.Duracion);
            texto.Append(", el numero de destino es: ");
            texto.Append(this.NroDestino);
            texto.Append(" y el numero de origen es: ");
            texto.Append(this.NroOrigen);

            return texto.ToString();
             
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        { 

        }



    }
}
