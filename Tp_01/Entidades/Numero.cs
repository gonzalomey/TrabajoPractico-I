using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public string SetNumero { set { numero = ValidarNumero(value); } }

        #region Constructores
        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero) : this(numero.ToString())
        {
           
        }

        public Numero(string strNumero)
        {
            this.SetNumero =strNumero;
        }
        #endregion

        #region Metodos
        private double ValidarNumero(string strNumero)
        {
            Double.TryParse(strNumero, out double num);

            return num;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            double retorno = n1.numero + n2.numero;
            return retorno;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double retorno = n1.numero - n2.numero;
            return retorno;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            double retorno = n1.numero * n2.numero;
            return retorno;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno;
            if(n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }
            else
            {
                retorno = double.MinValue;
            }
            
            return retorno;
        }


        public static string DecimalBinario(double numero)
        {
            string cadena = "";

            int aux = Convert.ToInt32(numero);//Tomo solo la parte entera del resultado

            if (aux > 0)
            {
                while (aux > 0)
                {
                    cadena = (aux % 2).ToString() + cadena;
                    aux = (int)aux / 2;
                }
            }

            else
            {
                if (aux == 0)
                {
                    cadena = "0";
                }

                else
                {
                    cadena = "Valor inválido";
                }
            }

            return cadena;
        }


        public static string DecimalBinario(string numero)
        {
         
            return DecimalBinario(double.Parse(numero));

        }

        public static string BinarioDecimal(string binario)
        {


            char[] numero = binario.ToCharArray(); //Calculo el tamaño del string recibido
            Array.Reverse(numero);
            string retorno;
            int sum = 0;

            if (Convert.ToDouble(binario) >= 0) //Si el tamaño es mayor a cero entra
            {
                for (int i= 0; i<numero.Length;i++) //Recorro el string recibido
                {
                    if(numero[i] == '1')
                    {
                        sum += (int)Math.Pow(2, i); 
                    }
                }

                retorno = Convert.ToString(sum);
            }

            else if (Convert.ToDouble(binario) == 0)
            {
                retorno = "0";
            }

            else
            {
                retorno = "Valor inválido";
            }

            return retorno;
        }
        #endregion
    }






}
