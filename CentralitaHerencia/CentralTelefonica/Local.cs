using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Local:Llamada
    {
        protected float _costo;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Local(Llamada llamada, float costo):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this._costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
        {
 
        }

        private float CalcularCosto()
        {
            float costo = this.Duracion * this._costo;

            return costo;
        }

        public string Mostrar()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append("La duracion es: ");
            texto.Append(this.Duracion);
            texto.Append(", el numero de destino es: ");
            texto.Append(this.NroDestino);
            texto.Append(", el numero de origen es: ");
            texto.Append(this.NroOrigen);
            texto.Append(" y el costo total es de: ");
            texto.Append(this.CostoLlamada);

            return texto.ToString();

        }


    }
}
