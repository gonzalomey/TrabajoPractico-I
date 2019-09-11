using System;

namespace Entidades
{
    public static class Calculadora
    {

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double result = 0;

            switch (ValidarOperador(operador))
            {
                case "+":
                    result = num1+num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    break;
            }
            return result;
        }


        private static string ValidarOperador(string operador)
        {

            switch (operador)
            {
                case "+":
                    return operador;
                case "-":
                    return operador;
                case "*":
                    return operador;
                case "/":
                    return operador;
                default:
                    operador = "+";
                    return operador;
            }
        }
    }
}
