using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {

        private int legajo;

        public Universitario()
        {

        }

        public Universitario(int legajo,string nombre,string apellido,string dni,ENacionalidad nacionalidad) : base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        protected abstract string ParticipaEnClase();

        protected virtual string MostrarDatos()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendFormat("{0}LEGAJO: {1}", base.ToString(), this.legajo);
            return aux.ToString();
        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if ((pg1.Equals(pg2) == true) && (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Universitario)
            {
                return true;
            }

            return false;
        }
    }
}
