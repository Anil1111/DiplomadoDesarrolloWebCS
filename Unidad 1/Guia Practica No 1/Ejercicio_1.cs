using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_No_1
{
    class Ejercicio_1
    {
        public void Ejercicio1_1()
        {
            //Sentence:
            //Escribir un programa que pida por teclado el lado de un cuadrado, mostrar por pantalla el perímetro del mismo

            double valor1, resultado;
            Console.WriteLine("===============>> PROGRAMA QUE CALCULA EL PERIMETRO DE UN CUADRADO <<===============");
            Console.WriteLine("Ingrese el valor del lado: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
            resultado = valor1 * 4;
            Console.WriteLine("El perímetro es {0}", resultado);
        }
    }
}
