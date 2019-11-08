using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Exceptions;

namespace Archivos
{
    public class Texto: IArchivos<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;

            try
            {
                StreamWriter auxArchivo = File.CreateText(archivo);
                auxArchivo.Write(datos);
                auxArchivo.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }

            return retorno;
        }

        public bool Leer(string archivo, out string datos)
        {
            bool retorno = false;

            try
            {
                StreamReader auxArchivo = new StreamReader(archivo);
                datos = auxArchivo.ReadToEnd();
                auxArchivo.Close();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }


            return retorno;
        }
    }
}
