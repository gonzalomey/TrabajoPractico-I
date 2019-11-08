using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Exceptions;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivos<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;

            try
            {
                XmlSerializer aux = new XmlSerializer(typeof(T));
                StreamWriter auxArchivo = new StreamWriter(archivo);
                aux.Serialize(auxArchivo, datos);
                auxArchivo.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }

            return retorno;
        }

        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;

            try
            {
                XmlSerializer aux = new XmlSerializer(typeof(T));
                StreamReader auxArchivo = new StreamReader(archivo);
                datos = (T)aux.Deserialize(auxArchivo);
                auxArchivo.Close();
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }

            retorno = true;

            return retorno;
        }

    }
}
