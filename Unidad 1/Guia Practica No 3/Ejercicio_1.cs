using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_No_3
{
    class Ejercicio_1
    {
        public void Ejercicio1_1()
        {
            //Sentence:
            //Una empresa tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados (4 por la mañana y 4 por la tarde)
            //Desarrollar un programa que permita almacenar los sueldos de los empleados agrupados por turno. 
            //Imprimir los gastos en sueldos de cada turno.

            List<Empleado> listEmpleado = new List<Empleado>();
            double gastosMatutinos = 0, gastosVespertinos = 0;
            string titulo = "===============>> PROGRAMA QUE CALCULA SALARIO EMPLEADOS POR TURNOS <<===============";

            for (int x = 1; x <= 4; x++)
            {
                Console.WriteLine(titulo);
                int turnoEmpleado;
                Console.WriteLine("Turno Matutino\n");
                Empleado empleado = new Empleado();
                Console.WriteLine("Ingrese el sueldo del empleado {0}: ", x);
                empleado.sueldo = Convert.ToDouble(Console.ReadLine());
                empleado.Turno = Empleado.TurnoEnum.Matutino.ToString();
                Console.Clear();
                listEmpleado.Add(empleado);
            }

            for (int x = 1; x <= 4; x++)
            {
                Console.WriteLine(titulo);
                int turnoEmpleado;
                Console.WriteLine("Turno Vespertino\n");
                Empleado empleado = new Empleado();
                Console.WriteLine("Ingrese el sueldo del empleado {0}: ", x);
                empleado.sueldo = Convert.ToDouble(Console.ReadLine());
                empleado.Turno = Empleado.TurnoEnum.Vespertino.ToString();
                Console.Clear();
                listEmpleado.Add(empleado);
            }

            foreach (Empleado empleado in listEmpleado)
            {
                if (empleado.Turno == Empleado.TurnoEnum.Matutino.ToString())
                    gastosMatutinos += empleado.sueldo;
                else
                    gastosVespertinos += empleado.sueldo;
            }

            Console.WriteLine(titulo);
            Console.WriteLine("\nEl gasto total para el turno matutino es de: ${0}", gastosMatutinos);
            Console.WriteLine("El gasto total para el turno vespertino es de: ${0}", gastosVespertinos);
        }

        public void Ejercicio1_2()
        {
            //Sentence:
            //Crear una matriz de 3 filas por 4 columnas e ingresar valores enteros, imprimir la primera fila.Imprimir la última fila e imprimir la primer columna

            Console.WriteLine("===============>> PROGRAMA QUE IMPRIME UNA MATRIZ DADA <<===============");

            int[,] matriz = new int[3, 4];
            int[] filaInicio = new int[4];
            int[] filaFinal = new int[4];
            int[] columnaInicio = new int[3];

            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;
            matriz[0, 3] = 4;

            matriz[1, 0] = 11;
            matriz[1, 1] = 12;
            matriz[1, 2] = 13;
            matriz[1, 3] = 14;

            matriz[2, 0] = 21;
            matriz[2, 1] = 22;
            matriz[2, 2] = 23;
            matriz[2, 3] = 24;

            for(int x = 0; x < 3; x++)
            {                
                for(int y = 0; y < 4; y++)
                {
                    if (x == 0)                    
                        filaInicio[y] = matriz[x, y];
                    if (x == 2)
                        filaFinal[y] = matriz[x, y];
                    if (y == 0)
                        columnaInicio[x] = matriz[x, y];
                }
            }

            Console.WriteLine("La primera fila es: ");

            foreach(int vector in filaInicio)
            {
                Console.Write(vector + " ");
            }

            Console.WriteLine("\nLa ultima fila es: ");

            foreach (int vector in filaFinal)
            {
                Console.Write(vector + " ");
            }

            Console.WriteLine("\nLa primera columna es: ");

            foreach (int vector in columnaInicio)
            {
                Console.Write(vector + " ");
            }


        }
    }

    class Empleado
    {
        public double sueldo { get; set; }
        public string Turno { get; set; }
        public enum TurnoEnum { Matutino = 1, Vespertino = 2 };

    }
}

