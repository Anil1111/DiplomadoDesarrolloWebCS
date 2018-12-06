using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_No_2
{
    class Ejercicio_1
    {
        public void Ejercicio1_1()
        {
            //Sentence:
            // Desarrollar un programa que imprima los múltiplos de 3 del 1 al 200 (Utilizar la Sentencia while)

            int x = 1, resultado;
            const int multiplicador = 3;

            string titulo = "===============>> PROGRAMA QUE IMPRIME LOS MULTIPLOS DEL 3 <<===============";

            Console.WriteLine(titulo + "\n");

            while(x<=200)
            {
                resultado = multiplicador * x;
                Console.WriteLine("El resultado de {0} por {1} es: {2}", multiplicador, x, resultado);
                x++;
            }


        }
    }
}
