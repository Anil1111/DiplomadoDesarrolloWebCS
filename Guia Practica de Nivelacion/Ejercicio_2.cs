using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Guia_Practica_de_Nivelacion
{
    public class Ejercicio_2
    {
        public void Ejercicio2()
        {
            //Sentence:
            //Realice el siguiente ejemplo

            double valor1 = 0, valor2 = 0, resultado = 0;
            Console.WriteLine("===============>> PROGRAMA QUE SUMA DOS NUMEROS <<===============");
            Console.WriteLine("Ingrese el primer valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());
            resultado = valor1 + valor2;
            Console.WriteLine("El resultado es {0}", resultado);

        }

        public void Ejercicio2_1()
        {
            //Sentence:
            //Escriba un programa que pida al usuario que escriba su nombre, 
            //y lo salude llamándolo por su nombre.

            string nombre;
            Console.WriteLine("===============>> PROGRAMA QUE SALUDA POR NOMBRE <<===============");
            Console.WriteLine("Por favor, Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Saludos {0}, Que tenga un buen día!", nombre);
        }

        public void Ejercicio2_2()
        {
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


        }
    }
}
