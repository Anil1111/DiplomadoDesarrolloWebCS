using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_No_1
{
    class Ejercicio_3
    {
        public void Ejercicio3_1()
        {
            //Sentence:
            //Escribir un programa que sea capaz de calcular el nuevo salario de un empleado si obtuvo un incremento del 40 % sobre su salario anterior.

            double valor1, resultado;
            Console.WriteLine("===============>> PROGRAMA QUE CALCULA AUMENTO 40% SALARIO <<===============");
            Console.WriteLine("Ingrese el salario a aumentar: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
            resultado = valor1 * 1.4;
            Console.WriteLine("El nuevo salario es de {0} pesos", resultado);
        }
    }
}
