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

        public void Ejercicio1_2()
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

        public void Ejercicio1_3()
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

        public void Ejercicio1_4()
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

        public void Ejercicio1_5()
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
