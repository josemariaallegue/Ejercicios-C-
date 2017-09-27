using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Provincial:Llamada
    {
        enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }

        protected Franja _franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                
            }
        }

        public Provincial(Franja miFranja, Llamada llamada):base (llamada.Duracion,llamada.NroDestino, llamada.NroOrigen)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
        {
            this._nroOrigen = origen;
            this._franjaHoraria = miFranja;
            this._duracion = duracion;
            this._nroDestino = destino;

        }

        private float CalcularCosto()
        {
            

            
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




    }
}
