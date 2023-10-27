using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecPrimerParcialLabo
{
    internal class Fabrica
    {
        // Atributos
        private int capacidad;
        private List<Vehiculo> vehiculos;

        // Constructores 

        private Fabrica()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Fabrica(int capacidad) : this()
        {
            this.capacidad = 10;

        }

        // Propiedades 

        public List<Vehiculo> Vehiculos
        {
            get
            {
                return vehiculos;
            }
        }

        public static Fabrica Instance
        { get; } = new Fabrica();

        // Operadores
        /// <summary>
        /// Operador de adición para agregar un vehículo a la lista de la fábrica.
        /// </summary>
        /// <param name="fabrica">La fábrica a la que se agregará el vehículo.</param>
        /// <param name="vehiculo">El vehículo que se agregará a la lista de la fábrica.</param>
        /// <returns>La fábrica modificada con el vehículo agregado si hay capacidad, de lo contrario, se devuelve la fábrica sin cambios.</returns>
        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica.vehiculos.Count < fabrica.capacidad)
            {
                fabrica.vehiculos.Add(vehiculo);
            }
            return fabrica;
        }
        /// <summary>
        /// Operador de sustracción para quitar un vehículo de la lista de la fábrica.
        /// </summary>
        /// <param name="fabrica">La fábrica de la que se eliminará el vehículo.</param>
        /// <param name="vehiculo">El vehículo que se eliminará de la lista de la fábrica.</param>
        /// <returns>La fábrica modificada con el vehículo eliminado si se encuentra, de lo contrario, se devuelve la fábrica sin cambios.</returns>
        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            var vehiculoEncontrado = fabrica.vehiculos.FirstOrDefault(v => v.GetType() == vehiculo.GetType() && v.ToString() == vehiculo.ToString());
            if (vehiculoEncontrado != null)
            {
                fabrica.vehiculos.Remove(vehiculoEncontrado);
            }
            return fabrica;
        }





    }
}
