using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_No_3
{
    class Ejercicio_2
    {
        public void Ejercicio2_1()
        {
            //Sentence:
            //Crear una matriz de 3 filas por 4 columnas e ingresar valores enteros, imprimir la primera fila.Imprimir la última fila e imprimir la primer columna

            Console.WriteLine("===============>> PROGRAMA QUE IMPRIME UNA MATRIZ DADA <<===============");

            int[,] matriz = new int[3, 4];
            int[] filaInicio = new int[4];
            int[] filaFinal = new int[4];
            int[] columnaInicio = new int[3];

            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;
            matriz[0, 3] = 4;

            matriz[1, 0] = 11;
            matriz[1, 1] = 12;
            matriz[1, 2] = 13;
            matriz[1, 3] = 14;

            matriz[2, 0] = 21;
            matriz[2, 1] = 22;
            matriz[2, 2] = 23;
            matriz[2, 3] = 24;

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (x == 0)
                        filaInicio[y] = matriz[x, y];
                    if (x == 2)
                        filaFinal[y] = matriz[x, y];
                    if (y == 0)
                        columnaInicio[x] = matriz[x, y];
                }
            }

            Console.WriteLine("La primera fila es: ");

            foreach (int vector in filaInicio)
            {
                Console.Write(vector + " ");
            }

            Console.WriteLine("\nLa ultima fila es: ");

            foreach (int vector in filaFinal)
            {
                Console.Write(vector + " ");
            }

            Console.WriteLine("\nLa primera columna es: ");

            foreach (int vector in columnaInicio)
            {
                Console.Write(vector + " ");
            }
        }
    }
}
