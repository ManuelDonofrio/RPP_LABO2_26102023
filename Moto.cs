using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecPrimerParcialLabo
{
    internal class Moto : Vehiculo
    {
        // Constructor 
        public Moto(Epropulsion propulsion) : base(propulsion) 
        { 
        }
        
        // Propiedad
        protected override string Tipo
        {
            get
            {
                return "Moto";
            }
        }

    }
}
