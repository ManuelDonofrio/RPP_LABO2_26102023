using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecPrimerParcialLabo
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;

        // Constructores 
        public Camioneta()
            : base() 
        {
            esAWD = true;
        }

        public Camioneta(Epropulsion propulsion, bool cabinaSimple)
        {
            this.propulsion = propulsion;
            this.cabinaSimple = cabinaSimple;
        }


        // Propiedades
        protected override string Tipo
        {
            get 
            { 
                return "Camioneta";
            }
        }

        // Métodos 
        /// <summary>
        /// Obtiene la información de la camioneta en un formato específico.
        /// </summary>
        /// <returns>Una cadena de texto con los datos de la misma</returns>
        new public string GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info.Append(base.GetInfo());
            info.Append(" con cabina: ");
            info.Append(this.cabinaSimple ? "false" : "true");

            return info.ToString();
        }


    }
}
