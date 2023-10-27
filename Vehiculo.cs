namespace RecPrimerParcialLabo
{
    public abstract class Vehiculo
    {
        public enum Epropulsion
        {
            Combustion,
            Hibrida,
            Electrica
        }

        // Atributos

        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected Epropulsion propulsion;

        // Constructores

        protected Vehiculo()
        {
            esAWD = false;
            numeroDeChasis = Guid.NewGuid();
        }

        protected Vehiculo(Epropulsion propulsion) : this()
        {
            this.propulsion = propulsion;
        }

        protected Vehiculo(Epropulsion propulsion, bool esAWD) : this()
        {
            this.propulsion = propulsion;
            this.esAWD = esAWD;
        }

        // Propiedades
        /// <summary>
        /// Propiedad de sólo lectura para obtener el tipo de propulsión
        /// </summary>
        public Epropulsion Propulsion
        {
            get 
            { 
                return propulsion;
            }
        }

        /// <summary>
        /// Propiedad de sólo lectura para obtener el tipo
        /// </summary>
        protected abstract string Tipo
        {
            get;
        }

        // Métodos 
        /// <summary>
        /// Obtiene la información del vehículo en un formato específico.
        /// </summary>
        /// <returns>Una cadena con la información del vehículo.</returns>
        protected string GetInfo()
        {
            string esAWDString = esAWD ? "SI" : "NO";
            string info = string.Format($"[{0}] con propulsión a [{1}], {2} es AWD, numero de chasis {3}.",
                this.Tipo, this.Propulsion, esAWDString, this.numeroDeChasis);
            return info;

        }
        /// <summary>
        /// Expone la información del vehiculo
        /// </summary>
        /// <returns> Retorna el método GetInfo con la información del vehículo</returns>
        public override string ToString()
        {
            return GetInfo();
        }


        // Operadores

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (ReferenceEquals(v1, null) && ReferenceEquals(v2, null))
            {
                return true; 
            }

            if (ReferenceEquals(v1, null) || ReferenceEquals(v2, null))
            {
                return false; 
            }

            return v1.GetType() == v2.GetType() && v1.numeroDeChasis == v2.numeroDeChasis;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }


    }
}