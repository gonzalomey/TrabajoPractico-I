using System;
using System.Collections.Generic;
using System.Text;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region Metodos
        private void _randomClases()
        {
            this.clasesDelDia.Enqueue(((Universidad.EClases)Profesor.random.Next(0, 4)));
            this.clasesDelDia.Enqueue(((Universidad.EClases)Profesor.random.Next(0, 4)));
        }

        protected override string MostrarDatos()
        {
            return (base.MostrarDatos() + this.ParticipaEnClase());
        }

        #region Operadores
        public static bool operator ==(Profesor p, Universidad.EClases clase)
        {
            bool retorno = false;
            foreach (Universidad.EClases cla in p.clasesDelDia)
            {
                if (cla == clase)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Profesor p, Universidad.EClases clase)
        {
            return !(p == clase);
        }
        #endregion

        protected override string ParticipaEnClase()
        {
            string retorno = "\nCLASES DEL DÍA: ";
            foreach (Universidad.EClases clases in this.clasesDelDia)
            {
                retorno += "\n" + clases.ToString();
            }
            return retorno;
        }

        #region Constructores
        static Profesor()
        {
            Profesor.random = new Random();
        }

        public Profesor()
        {
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        #endregion

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

    }
}
