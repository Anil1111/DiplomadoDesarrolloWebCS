using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_de_Nivelacion
{
    class Ejercicio_5
    {
        public void Ejercicio5_1()
        {
            //Sentence:
            //Un programa que muestre la tabla de multiplicar del número 4.

            double resultado;

            Console.WriteLine("===============>> PROGRAMA QUE CALCULA LA TABLA DE MULTIPLICAR 4 <<===============");

            int tabla = 1;
            while (tabla <= 12)
            {
                resultado = tabla * 4;
                Console.WriteLine("El resultado de la multiplicacion de {0} por 4 es: {1} ", tabla, resultado);

                tabla++;
            }
        }

        public void Ejercicio5_2()
        {
            //Sentence:
            //Crear un menú de opciones usando do while que imprima la tabla de multiplicar deseada por el
            //usuario y calcule promedio.


            string menu = null;

            
            do           
            {
                Console.WriteLine();
                Console.WriteLine("===============>> MENÚ DE OPCIONES <<===============");
                Console.WriteLine("TABLA DE MULTIPLICAR [T]");
                Console.WriteLine("CALCULAR PROMEDIO [P]");
                Console.WriteLine("LIMPIAR PANTALLA [L]");
                Console.WriteLine("SALIR [S]");
                Console.WriteLine("====================================================");
                Console.WriteLine("Presione las teclas correspondientes para acceder al programa ");

                menu = Console.ReadLine().ToLower();

                switch(menu)
                {
                    case "t":
                        
                        //Sentence:
                        //Un programa que muestre la tabla de multiplicar

                        double resultado, valor;

                        Console.WriteLine("===============>> PROGRAMA QUE CALCULA LA TABLA DE MULTIPLICAR <<===============");
                        Console.WriteLine("Ingrese el valor a multiplicar: ");
                        valor = Convert.ToDouble(Console.ReadLine());

                        for (int x = 1; x <= 12; x++)
                        {
                            resultado = x * valor;
                            Console.WriteLine("El resultado de la multiplicacion de {0} por {1} es: {2} ", valor, x, resultado);
                        }
                        break;

                    case "p":

                        //Sentence:
                        //Crear una aplicación en C# que calcule promedio de cuatro notas. Las variables a utilizar son nota
                        //enero, nota febrero, nota marzo, nota abril y promedio. 

                        int nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;
                        double promedio;

                        Console.WriteLine("===============>> PROGRAMA QUE CALCULA PROMEDIO 4 NOTAS <<===============");
                        Console.WriteLine("Ingrese Nota Correspondiente a Enero: ");
                        nota1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Nota Correspondiente a Febrero: ");
                        nota2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Nota Correspondiente a Marzo: ");
                        nota3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Nota Correspondiente a Abril: ");
                        nota4 = Convert.ToInt32(Console.ReadLine());
                        promedio = (nota1 + nota2 + nota3 + nota4) / 4;
                        Console.WriteLine("El promedio del cuatrimeste es de: {0}", promedio);
                        break;

                    case "l":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Gracias por utilizar el programa!");
                        menu = "s";
                        break;                }

                
            }
            while (menu != "s") ;
        }
    }
}
