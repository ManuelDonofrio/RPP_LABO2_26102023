using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecPrimerParcialLabo
{
    internal class Automovil : Vehiculo
    {
        // Constructor
        public Automovil()
            : base(Epropulsion.Hibrida)
        {
        }
        // Propiedades
        protected override string Tipo
        {
            get
            {
                return "Automovil";
            }
        }
    }
}
