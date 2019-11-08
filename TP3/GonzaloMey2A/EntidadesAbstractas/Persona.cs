using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Exceptions;

namespace EntidadesAbstractas
{
    public abstract class Persona 
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero

        }


        private string nombre;
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;


        public string Nombre { get { return this.nombre; } set { this.nombre = ValidarNombreApellido(value); } }
        public string Apellido { get { return this.apellido; } set { this.apellido = ValidarNombreApellido(value); } }
        public int DNI { get { return this.dni; } set { this.dni = ValidarDni(this.Nacionalidad, value); } }
        public ENacionalidad Nacionalidad { get { return this.nacionalidad; } set { this.nacionalidad = value; } }
        public string StringToDNI { set {this.DNI= ValidarDni(this.Nacionalidad, value); } }

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) :this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI = dni;
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int aux = 0;

            aux = ValidarDni(nacionalidad, dato.ToString());//Reutilizamos codigo

            return aux;
        }


        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno = 0; //Es invalido
            int auxDni;
            Regex soloNumeros = new Regex("^[0-9]+?$");

            if (soloNumeros.IsMatch(dato))//si el "Dato" es solo numeros continuar
            {
                bool validacion = Int32.TryParse(dato, out auxDni);

                if (validacion == true) //Si el dni es valido continua, de lo contrario lanzara una excepcion
                {
                    if ((nacionalidad == ENacionalidad.Argentino) && (auxDni > 0) && (auxDni <= 89999999))
                    {
                        retorno = auxDni;
                    }
                    else if ((nacionalidad == ENacionalidad.Extranjero) && (auxDni >= 90000000) && (auxDni <= 99999999))
                    {
                        retorno = auxDni;
                    }
                    else
                    {
                        throw new NacionalidadInvalidaException();
                    }
                }
                else
                {
                    throw new DniInvalidoException();
                }

            }
            else
            {
                throw new DniInvalidoException();
            }

            return retorno;

        }
        private string ValidarNombreApellido(string dato)
        {
            Regex Val = new Regex(@"^[a-zA-Z]+$");
            //Si el dato pasasdo como parametro contiene otra cosa que no sea un caracter, me devuelve true
            if (Val.IsMatch(dato))
            {
                return dato;
            }

            return null;
        }

        public override string ToString()
        {
            StringBuilder auxiliar = new StringBuilder();
            auxiliar.AppendFormat(" NOMBRE COMPLETO: {0}, {1}\n", this.Apellido, this.Nombre);
            auxiliar.AppendFormat("NACIONALIDAD: {0}\n", this.Nacionalidad);

            return auxiliar.ToString();
        }


    }
}
