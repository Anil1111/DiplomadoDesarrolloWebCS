using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_No_2
{
    class Ejercicio_3
    {
        //Sentence:
        // Realizar un programa que permita ingresar n números enteros por el teclado y se desea conocer:
        //a) La cantidad de números positivos.
        //b) La cantidad de números negativos.
        //c) La cantidad de números pares.
        //d) La cantidad de números impares
        int[] vector;
        int positivo, negativo, par, impar;

        string titulo = "===============>> PROGRAMA QUE CALCULA TIPO DE VALORES INGRESADOS <<===============";

        public void Ejercicio3_1()
        {
            Console.WriteLine(titulo + "\n");
            Console.WriteLine("Ingrese la cantidad de valores que desea ingresar");
            vector = new int[Convert.ToInt32(Console.ReadLine())];

            for(int x = 0; x < vector.Length; x++)
            {
                Console.WriteLine("Ingrese un valor: ");
                vector[x] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int v in vector)
            {
                if (v >= 0)
                    positivo++;
                if (v < 0)
                    negativo++;
                if (v % 2 == 0)
                    par++;
                if (v % 2 != 0)
                    impar++;
            }

            Console.Clear();
            Console.WriteLine(titulo + "\n");
            Console.WriteLine("Se han ingresado {0} valores positivos", positivo);
            Console.WriteLine("Se han ingresado {0} valores negativos", negativo);
            Console.WriteLine("Se han ingresado {0} valores pares", par);
            Console.WriteLine("Se han ingresado {0} valores impares", impar);

        }
    }
}
