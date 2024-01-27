using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
        /// <summary>
        /// Implementa operaçoes aritméticas.
        /// </summary>
    internal static class Aritmetica
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar.
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        /// <summary>
        /// Operação soma.
        /// </summary>
        /// <returns>Retorna a soma de dois números.</returns>
        public static int Somar(int x, int y)
        { 
            return x + y; 
        }

        /// <summary>
        /// Operação de subtração.
        /// </summary>
        /// <returns>Retorna o resultado da subtração de dois números.</returns>
        public static int Subtrair(int x, int y)
        { 
            return x - y; 
        }

        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            { 
                return (temperatura * 1.800 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.800);
            }

            return -1;
        }
    }
}
