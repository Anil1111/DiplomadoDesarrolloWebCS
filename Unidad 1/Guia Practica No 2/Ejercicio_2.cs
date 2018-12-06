using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_No_2
{
    class Ejercicio_2
    {
        //Sentence:
        // Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
        //Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5 %.
        //Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios

        double salario, antiguedad, resultado;

        string titulo = "===============>> PROGRAMA QUE CALCULA SALARIO OPERARIO POR ANTIGUEDAD <<===============";

        public void Ejercicio2_1()
        {
            Console.WriteLine(titulo + "\n");

            Console.WriteLine("Ingrese el salario del operario: ");
            salario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la antiguedad del operario en la empresa: ");
            antiguedad = Convert.ToInt32(Console.ReadLine());

            if (salario < 500 && antiguedad > 10)
                resultado = salario * 1.20;
            else if (salario < 500 && antiguedad <= 10)
                resultado = salario * 1.05;
            else
                resultado = salario;

            Console.WriteLine("El salario a pagar es: ${0} pesos", resultado);

        }
    }
}
