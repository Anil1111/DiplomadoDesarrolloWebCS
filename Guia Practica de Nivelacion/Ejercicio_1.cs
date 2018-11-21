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

        private string nombre { get; set; }
        private string apellido { get; set; }
        private string apodo { get; set; }
        private DateTime fechaNacimiento { get; set; }
        private string telefono { get; set; }
        private string movil { get; set; }
        private string pais { get; set; }
        private string ciudad { get; set; }
        private string direccion { get; set; }
        private string lugarTrabajo { get; set; }
        private Double sueldo { get; set; }

        public void Ejercicio()
        {
            nombre = "Juan";
            apellido = "Perez";
            apodo = "Pepito";
            fechaNacimiento = Convert.ToDateTime("01/01/2000");
            telefono = "809-555-5555";
            movil = "829-444-4444";
            pais = "República Dominicana";
            ciudad = "Santo Domingo";
            direccion = "Mirador Sur";
            lugarTrabajo = "Junta Central Electoral";
            sueldo = 80000.00;

            Console.WriteLine("===============>> INFORMACIÓN PERSONAL <<===============");
            Console.WriteLine("NOMBRE:  " + nombre);
            Console.WriteLine("APELLIDO:  " + apellido);
            Console.WriteLine("APODO:  " + apodo);
            Console.WriteLine("FECHA DE NACIMIENTO:  " + fechaNacimiento.ToString("dd/MM/yyyy"));
            Console.WriteLine("TELEFONO:  " + telefono);
            Console.WriteLine("MOVIL:  " + movil);
            Console.WriteLine("PAIS:  " + pais);
            Console.WriteLine("CIUDAD:  " + ciudad);
            Console.WriteLine("DIRECCION:  " + direccion);
            Console.WriteLine("LUGAR DE TRABAJO:  " + lugarTrabajo);
            Console.WriteLine("SUELDO:  " + sueldo);
        }
    }
}
