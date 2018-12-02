using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_No_1
{
    class Ejercicio_5
    {
        public void Ejercicio5_1()
        {
            //Sentence:
            //Escribir un programa que pida por teclado el lado de un cuadrado, mostrar por pantalla el perímetro del mismo

            double masculinos, femeninas, total;
            double resultadoM, resultadoF;
            Console.WriteLine("===============>> PROGRAMA QUE CALCULA CANTIDAD EN PORCENTAJE DE ESTUDIANTES MASC. Y FEM. DEL AULA <<===============");
            Console.WriteLine("Ingrese cantidad de estudiantes masculinos: ");
            masculinos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de estudiantes femeninas: ");
            femeninas = Convert.ToInt32(Console.ReadLine());

            total = femeninas + masculinos;
            resultadoM = (masculinos / total) * 100;
            resultadoF = (femeninas / total) * 100;
            Console.WriteLine("El porcentaje de estudiantes masculinos es {0}%", resultadoM.ToString("n2"));
            Console.WriteLine("El porcentaje de estudiantes femeninas es {0}%", resultadoF.ToString("n2"));
        }
    }
}
