using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_de_Nivelacion
{
    class Ejercicio_4
    {
        public void Ejercicio4_1()
        {
            //Sentence:
            //Escribir un programa que muestre los números del 1 al 100

            Console.WriteLine("===============>> PROGRAMA QUE CUENTA DEL 1 AL 100 <<===============");            
            for (int x = 1; x <= 100; x++)
            {
                Console.WriteLine(x);
            }
        }

        public void Ejercicio4_2()
        {
            //Sentence:
            //Un programa que muestre los números del 100 al 105

            Console.WriteLine("===============>> PROGRAMA QUE CUENTA DEL 100 AL 105 <<===============");
            for (int x = 100; x <= 105; x++)
            {
                Console.WriteLine(x);
            }
        }

         public void Ejercicio4_3()
        {
            //Sentence:
            //Un programa que muestre los números del 3 al 20 con su cubo al lado.

            double cubo;

            Console.WriteLine("===============>> PROGRAMA QUE CUENTA LOS NUMEROS Y SU CUBO <<===============");
            for (int x = 3; x <= 20; x++)
            {
                cubo = Math.Pow(x, 3);
                Console.WriteLine("El resultado del cubo de {0} es: {1} ", x, cubo);
            }
        }

        public void Ejercicio4_4()
        {
            //Sentence:
            //Un programa que muestre la tabla de multiplicar del número 4

            double resultado;

            Console.WriteLine("===============>> PROGRAMA QUE CALCULA LA TABLA DE MULTIPLICAR 4 <<===============");
            for (int x = 1; x <= 12; x++)
            {
                resultado = x * 4;
                Console.WriteLine("El resultado de la multiplicacion de {0} por 4 es: {1} ", x, resultado);
            }
        }

        public void Ejercicio4_5()
        {
            //Sentence:
            //Un programa que muestre todas las tablas de multiplicar, esto es, la del 1, 2, 3,4. Hasta el 12 usando dos bucles anidados.

            double resultado;

            Console.WriteLine("===============>> PROGRAMA QUE CALCULA TODAS LAS TABLAS DE MULTIPLICAR <<===============");
            for (int x = 1; x <= 12; x++)
            {
                for(int y = 1; y <=12; y++)
                {
                resultado = x * y;
                Console.WriteLine("El resultado de la multiplicacion de {0} por {1} es: {2} ", x, y, resultado);

                }
                Console.WriteLine("-------------------------------------------------------------");
            }
        }
    }
}
