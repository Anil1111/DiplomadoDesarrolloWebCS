using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_de_Nivelacion
{
    class Ejercicio_6
    {
        public void Ejercicio6_1()
        {
            //Sentence:
            //Crear una aplicación que cargue un vector de 5 códigos validos. Los códigos ingresaran por teclado.

            string[] vector = new string[5];

            Console.WriteLine("===============>> PROGRAMA QUE ALMACENA UN VECTOR DE INDICE 5<<===============");

            for (int x = 0; x < vector.Length; x++)
            {
                Console.WriteLine("Ingrese el codigo a almacenar: ");
                vector[x] = Console.ReadLine();
            }

            Console.WriteLine("\nLos valores almacenados son: ");
            for (int x = 0; x < vector.Length; x++)
                Console.WriteLine(vector[x] + " ");
        }

        public void Ejercicio6_2()
        {
            //Sentence:
            //Crear una aplicación que calcule e imprima la sumatoria de los elementos de un vector. 
            //Los elementos ingresarán por teclado.


            int[] vector;
            int capacidad, sumatoria = 0;

            Console.WriteLine("===============>> PROGRAMA QUE REALIZA UNA SUMATORIA DE VECTORES <<===============");

            Console.WriteLine("Ingrese el tamaño del vector que desea sumar: ");
            capacidad = Convert.ToInt32(Console.ReadLine());

            vector = new int[capacidad];

            for (int x = 0; x < vector.Length; x++)
            {
                Console.WriteLine("Ingrese el valor a sumar: ");
                vector[x] = Convert.ToInt32(Console.ReadLine());
                sumatoria += vector[x];
            }

            Console.WriteLine("El resultado de la sumatoria del vector dado es: {0} ", sumatoria);            
        }

        public void Ejercicio6_3()
        {
            //Sentence: 
            //Escriba un programa en C# que llene esta tabla con nombres de personas. 
            //La información se visualizará de la misma manera con dos bucles.

            string[,] tabla = new string[2, 3];

            tabla[0, 0] = "Juan";
            tabla[0, 1] = "Pedro";
            tabla[0, 2] = "Jose";

            tabla[1, 0] = "Maria";
            tabla[1, 1] = "Rosa";
            tabla[1, 2] = "Minerva";

            for(int x = 0; x < 2; x++)
            {
                Console.WriteLine();

                for(int y = 0; y < 3; y++)
                {
                    Console.Write(tabla[x, y] + " ");
                }
            }
        }

        public void Ejercicio6_4()
        {
            //Sentence: 
            //Crear un programa que sume dos matrices, la matriz A y la matriz B. 
            //Imprimir la matriz resultante C.

            int[,] matrizA = new int[2, 2];
            int[,] matrizB = new int[2, 2];
            int[,] matrizC = new int[2, 2];


            matrizA[0, 0] = 70;
            matrizA[0, 1] = 60;
            matrizA[1, 0] = 80;
            matrizA[1, 1] = 70;

            matrizB[0, 0] = 68;
            matrizB[0, 1] = 90;
            matrizB[1, 0] = 80;
            matrizB[1, 1] = 70;

            Console.WriteLine("La sumatoria de las matrices A y B es: ");
            for (int x = 0; x < 2; x++)
            {
                Console.WriteLine();

                for (int y = 0; y < 2; y++)
                {
                    matrizC[x, y] = matrizA[x, y] + matrizB[x, y];
                    Console.Write(matrizC[x, y] + " ");
                }
            }
        }
    }
}
