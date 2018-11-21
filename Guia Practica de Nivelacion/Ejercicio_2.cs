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

        public void Ejercicio2_3()
        {
            //Sentence:
            //Escribir un programa en C# que ingrese el nombre de un producto, el precio y la cantidad. El
            //programa calculará el ITBIS que es del 18 %.Imprimir el sub total, el monto de itbis y el total a pagar.

            string nombreProducto;
            double precio, cantidad, impuesto = 0, total, subtotal;

            Console.WriteLine("===============>> PROGRAMA QUE CALCULA ITBIS <<===============");
            Console.WriteLine("Ingrese Nombre del Producto: ");
            nombreProducto = Console.ReadLine();
            Console.WriteLine("Ingrese precio del Producto: ");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad del Producto: ");
            cantidad = Convert.ToDouble(Console.ReadLine());
            subtotal = cantidad * precio;
            Console.WriteLine("Sub Total: ${0}", subtotal.ToString("N"));
            impuesto = subtotal * 0.18;
            Console.WriteLine("Impuesto: ${0}", impuesto.ToString("N"));
            total = subtotal + impuesto;
            Console.WriteLine("Sub Total: ${0}", total.ToString("N"));
        }

        public void Ejercicio2_4()
        {
            //Sentence:
            //Escribir un programa en  C# que calcule sueldo bruto (SB), sueldo neto (SN) y descuento (DD). Las
            //tarifas por horas(HT) y horas trabajadas(TH) se ingresan por teclado. El descuento aplicar a todos los
            //sueldos calculados es del 10 %.Imprimir sueldo bruto, descuento y sueldo neto.

            double SB, SN, DD, HT, TH;            Console.WriteLine("===============>> PROGRAMA QUE CALCULA SUELDO <<===============");
            Console.WriteLine("Ingrese costo de tarifa por hora: ");            HT = Convert.ToDouble(Console.ReadLine());            Console.WriteLine("Ingrese total de horas trabajadas: ");            TH = Convert.ToDouble(Console.ReadLine());            SB = HT * TH;            Console.WriteLine("El sueldo bruto es: ${0}", SB.ToString("N"));            DD = SB * 0.10;            Console.WriteLine("El descuento es: ${0}", DD.ToString("N"));            SN = SB - DD;            Console.WriteLine("El sueldo neto es: ${0}", SN.ToString("N"));
        }

        public void Ejercicio2_5()
        {
            //Sentence: 
            //Escriba un programa que convierta de centímetros a pulgadas. Una pulgada es igual a 2.54
            //centímetros. Los centímetros ingresan por teclado.

            double centimetro, pulgada;            Console.WriteLine("===============>> PROGRAMA QUE CONVIERTE DE CENTIMETROS A PULGADAS <<===============");
            Console.WriteLine("Ingrese los centimetros a convertir: ");            centimetro = Convert.ToDouble(Console.ReadLine());            pulgada = centimetro * 2.54;            Console.WriteLine("El resultado es: {0} pulgadas", pulgada);
        }

        public void Ejercicio2_6()
        {
            //Sentence:
            //Crear un programa en C# que calcule la cuota (c) de un préstamo simple. El monto (m) del
            //préstamo, interés(i) y el tiempo(t) ingresaran por teclado.
            //Formula:
            //c = ((m * i) / t) + (m / t)

            double c, m, i, t;
            Console.WriteLine("===============>> PROGRAMA QUE CALCULA LA CUOTA DE UN PRESTAMO SIMPLE <<===============");
            Console.WriteLine("Ingrese el monto del Prestamo: ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la tasa de interes: ");
            i = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.WriteLine("Ingrese el plazo en que se saldara el prestamo: ");
            t = Convert.ToDouble(Console.ReadLine());
            c = ((m * i) / t )+ (m / t);
            Console.WriteLine("Las Cuotas son de: ${0} pesos", c.ToString("N"));

        }
    }
}
