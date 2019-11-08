using System;
using System.Collections.Generic;
using System.Text;
using Exceptions;
using Archivos;

namespace EntidadesInstanciables
{
    public class Jornada
    {
        #region Atributos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }

            set
            {
                this.clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }

            set
            {
                this.instructor = value;
            }
        }
        #endregion

        #region Metodos
        public static bool Guardar(Jornada jornada)
        {
            Texto t = new Texto();
            return t.Guardar((AppDomain.CurrentDomain.BaseDirectory + @"/Jornadas.txt"), jornada.ToString());
        }

        #region Constructor
        private Jornada()
        {
            this.Alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.Clase = clase;
            this.instructor = instructor;
        }
        #endregion

        public static string Leer()
        {
            string retorno = "";
            Texto t = new Texto();
            t.Leer((AppDomain.CurrentDomain.BaseDirectory) + @"\Jornada.txt", out retorno);
            return retorno;
        }

        #region Operadores
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return j;
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;
            foreach (Alumno alumno in j.Alumnos)
            {
                if (alumno == a)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        #endregion

        public override string ToString()
        {
            string retorno = "";
            StringBuilder sb = new StringBuilder();
            retorno = "\nClase de " + this.Clase + " por " + this.Instructor + ". \n\nALUMNOS:\n";
            foreach (Alumno a in this.alumnos)
            {
                retorno += a.ToString() + "\n\n";
            }
            return retorno;
        }

        #endregion

    }
}
