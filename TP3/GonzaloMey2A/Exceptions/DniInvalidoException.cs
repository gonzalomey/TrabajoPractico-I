using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class DniInvalidoException : Exception
    {

        private const string mensajeBase = "El Dni no es valido";

        public DniInvalidoException() : this(mensajeBase, null)
        {

        }

        public DniInvalidoException(Exception e) : this(mensajeBase, e)
        {

        }

        public DniInvalidoException(string message) : this(message, null)
        {

        }

        public DniInvalidoException(string message, Exception e) : base(message, e)
        {

        }
    }
}
