using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_No_1
{
    class Ejercicio_4
    {
        public void Ejercicio4_1()
        {
            //Sentence:
            //Escribir un programa que solicite por teclado una cantidad en pesos, obtener la equivalencia en dólares, 
            //tomando en cuenta que la unidad cambiaria es un valor variable.

            double peso, tasa, resultado;
            Console.WriteLine("===============>> PROGRAMA QUE CALCULA EL INTERCAMBIO DE PESO A DOLAR <<===============");
            Console.WriteLine("Ingrese el valor de la tasa del dolar: ");
            tasa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el monto en pesos a convertir: ");
            peso = Convert.ToDouble(Console.ReadLine());
            resultado = peso / tasa;
            Console.WriteLine("El monto en dolares es {0}", resultado);
        }
    }
}
