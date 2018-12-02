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
    }

    class Empleado
    {
        public double sueldo { get; set; }
        public string Turno { get; set; }
        public enum TurnoEnum { Matutino = 1, Vespertino = 2 };

    }
}

