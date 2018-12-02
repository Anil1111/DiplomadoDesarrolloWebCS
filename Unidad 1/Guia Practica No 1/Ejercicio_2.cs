using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_No_1
{
    class Ejercicio_2
    {
        public void Ejercicio2_1()
        {
            //Sentence:
            //Escribir un programa que calcule la “Masa” de aire, pidiendo por teclado la presión, el volumen y la temperatura
            // teniendo en cuenta que la fórmula es: masa = (presión * volumen)/ (0.37 * (temperatura + 460))

            double presion, volumen, temperatura, resultado;
            Console.WriteLine("===============>> PROGRAMA QUE CALCULA LA MASA DEL AIRE <<===============");
            Console.WriteLine("Ingrese el valor de la presión: ");
            presion = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del volumen: ");
            volumen = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la temperatura: ");
            temperatura = Convert.ToDouble(Console.ReadLine());

            resultado = (presion * volumen) / (0.37 * (temperatura + 460));
            Console.WriteLine("El resultado de la masa es: {0}", resultado);
        }
    }
}
