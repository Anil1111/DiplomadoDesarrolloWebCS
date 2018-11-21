using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Guia_Practica_de_Nivelacion
{
    class Ejercicio_3
    {
        public void Ejercicio3_1()
        {
            //Sentence:
            //Escribir un programa que java que calcule sueldo bruto(SB), sueldo neto(SN) y descuento(DD).
            //Las tarifas por horas(HT) y horas trabajadas(TH) ingresan por teclado. Si el sueldo bruto es mayor
            //a 5,000.00 se descuenta un 10 %, de lo contrario se descuenta un 5 %. 
            //Imprimir sueldo bruto, descuento y sueldo neto.

            double SB, SN, DD = 0, HT, TH;
            Console.WriteLine("===============>> PROGRAMA QUE CALCULA SUELDO 2.0 <<===============");
            Console.WriteLine("Ingrese costo de tarifa por hora: ");
            HT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese total de horas trabajadas: ");
            TH = Convert.ToDouble(Console.ReadLine());
            SB = HT * TH;
            Console.WriteLine("El sueldo bruto es: ${0}", SB.ToString("N"));
            if (SB > 5000)
            {
                DD = SB * 0.10;
            }
            else
            {
                DD = SB * 0.05;
            }
            
            Console.WriteLine("El descuento es: ${0}", DD.ToString("N"));
            SN = SB - DD;
            Console.WriteLine("El sueldo neto es: ${0}", SN.ToString("N"));
        }

        public void Ejercicio3_2()
        {
            //Sentence:
            //Escribir un programa en C# que calcule el promedio de 4 notas tomando en cuenta el siguiente criterio para el resultado
            //Condición || Desplegar en pantalla
            //0 a < 65 Reprobado
            //65 a < 75 Aprobado
            //75 a < 85 Muy bueno
            //85 a < 90 Sobresaliente
            //90 a < 100 Excelente

            int nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;
            double promedio;

            Console.WriteLine("===============>> PROGRAMA QUE CALCULA PROMEDIO 4 NOTAS 2.0 <<===============");
            Console.WriteLine("Ingrese Nota Correspondiente a Enero: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Nota Correspondiente a Febrero: ");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Nota Correspondiente a Marzo: ");
            nota3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Nota Correspondiente a Abril: ");
            nota4 = Convert.ToInt32(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            if(promedio > 90 && promedio <=100)
                Console.WriteLine("El promedio del cuatrimeste es de: {0}, Excelente!!", promedio);
            else if (promedio > 85 && promedio <= 90)
                Console.WriteLine("El promedio del cuatrimeste es de: {0}, Sobresaliente!!", promedio);
            else if (promedio > 75 && promedio <= 85)
                Console.WriteLine("El promedio del cuatrimeste es de: {0}, Muy bueno!!", promedio);
            else if (promedio > 65 && promedio <= 75)
                Console.WriteLine("El promedio del cuatrimeste es de: {0}, Aprobado!!", promedio);
            else if (promedio > 0 && promedio <= 65)
                Console.WriteLine("El promedio del cuatrimeste es de: {0}, Reprobado", promedio);
            else
            {
                Console.WriteLine("Los parametros introducidos son incorrectos, Por favor Volver a intentar...");
            }


        }

        public void Ejercicio3_3()
        {
            //Sentence:
            //Escribir un programa en C# que pida la edad de una persona y muestre en pantalla lo siguiente según criterio:
            //Desplegar en pantalla || Condición
            //Bebé En el caso de que la edad sea 0 ó 1
            //Niño En el caso de que la edad sea mayor o igual que 2 y menor o igual que 12.
            //Adolescente En el caso de que la edad sea mayor o igual que 13 y menor o igual que 17.
            //Joven En el caso de que la edad sea mayor o igual que 18 y menor o igual que 30.
            //Adulto En el caso de que la edad sea mayor o igual que 31 y menor o igual que 64.
            //Anciano En el caso de que la edad sea mayor o igual que 65 y menor o igual que 120.
            //Error Edad incorrecta.En el caso de que la edad sea menor que 0 o mayor que 125.

            int edad;
            Console.WriteLine("===============>> PROGRAMA QUE CATEGORIZA POR EDAD <<===============");
            Console.WriteLine("Ingrese la edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 65 && edad <= 120)
                Console.WriteLine("Con {0} años usted esta categorizado como un anciano", edad);
            else if (edad >= 31 && edad <= 64)
                Console.WriteLine("Con {0} años usted esta categorizado como un adulto", edad);
            else if (edad >= 18 && edad <= 30)
                Console.WriteLine("Con {0} años usted esta categorizado como un joven", edad);
            else if (edad >= 13 && edad <= 17)
                Console.WriteLine("Con {0} años usted esta categorizado como un anciano", edad);
            else if (edad >= 2 && edad <= 12)
                Console.WriteLine("Con {0} años usted esta categorizado como un anciano", edad);
            else if (edad == 0 || edad == 1)
                Console.WriteLine("Con {0} años usted esta categorizado como un anciano", edad);
            else
                Console.WriteLine("Error: Edad incorrecta");
        }
        public void Ejercicio3_4()
        {
            //Escribir un programa en C# que despliegue el nombre del día de la semana. El número del día ingresara por teclado.

            int diaSemana;
            Console.WriteLine("===============>> PROGRAMA QUE DESPLIEGA DIA DE SEMANA <<===============");
            Console.WriteLine("Ingrese el número del dia de la Semana: ");
            diaSemana = Convert.ToInt32(Console.ReadLine());

            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("El dia de la semana {0} corresponde a Lunes", diaSemana);
                    break;
                case 2:
                    Console.WriteLine("El dia de la semana {0} corresponde a Martes", diaSemana);
                    break;
                case 3:
                    Console.WriteLine("El dia de la semana {0} corresponde a Miercoles", diaSemana);
                    break;
                case 4:
                    Console.WriteLine("El dia de la semana {0} corresponde a Jueves", diaSemana);
                    break;
                case 5:
                    Console.WriteLine("El dia de la semana {0} corresponde a Viernes", diaSemana);
                    break;
                case 6:
                    Console.WriteLine("El dia de la semana {0} corresponde a Sabado", diaSemana);
                    break;
                case 7:
                    Console.WriteLine("El dia de la semana {0} corresponde a Domingo", diaSemana);
                    break;
                default:
                    Console.Write("El numero ingresado no es valido, Por Favor intentarlo nuevamente...");
                    break;
            }
        }
    }
}
