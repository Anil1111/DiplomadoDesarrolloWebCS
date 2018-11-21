using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Guia_Practica_de_Nivelacion
{
    public class Ejercicio_1
    {
        //Sentence:
        //Crea una aplicación en C# que muestre información de una persona. 
        //La información a mostrar es: nombre, apellido, apodo, fecha nacimiento, teléfono,
        //móvil, país, cuidad, dirección, lugar de trabajo, sueldo.

        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Apodo { get; set; }
        private DateTime FechaNacimiento { get; set; }
        private string Telefono { get; set; }
        private string Movil { get; set; }
        private string Pais { get; set; }
        private string Ciudad { get; set; }
        private string Direccion { get; set; }
        private string LugarTrabajo { get; set; }
        private Double Sueldo { get; set; }

        public void Ejercicio1()
        {
            Nombre = "Juan";
            Apellido = "Perez";
            Apodo = "Pepito";
            FechaNacimiento = Convert.ToDateTime("01/01/2000");
            Telefono = "809-555-5555";
            Movil = "829-444-4444";
            Pais = "República Dominicana";
            Ciudad = "Santo Domingo";
            Direccion = "Mirador Sur";
            LugarTrabajo = "Junta Central Electoral";
            Sueldo = 80000.00;

            Console.WriteLine("===============>> INFORMACIÓN PERSONAL <<===============");
            Console.WriteLine("NOMBRE:  " + Nombre);
            Console.WriteLine("APELLIDO:  " + Apellido);
            Console.WriteLine("APODO:  " + Apodo);
            Console.WriteLine("FECHA DE NACIMIENTO:  " + FechaNacimiento.ToString("dd/MM/yyyy"));
            Console.WriteLine("TELEFONO:  " + Telefono);
            Console.WriteLine("MOVIL:  " + Movil);
            Console.WriteLine("PAIS:  " + Pais);
            Console.WriteLine("CIUDAD:  " + Ciudad);
            Console.WriteLine("DIRECCION:  " + Direccion);
            Console.WriteLine("LUGAR DE TRABAJO:  " + LugarTrabajo);
            Console.WriteLine("SUELDO:  " + Sueldo);
        }
    }
}
