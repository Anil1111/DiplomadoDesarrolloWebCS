using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_No_4
{
    class Empleado
    {
        //Sentence:
        //Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo.
        //Confeccionar los métodos para la carga, otro para imprimir sus datos y por último
        // uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 30,000)

        private string Nombre { get; set; }
        private double Sueldo { get; set; }

        public void Cargar(string nombre, double sueldo)
        {
            this.Nombre = nombre;
            this.Sueldo = sueldo;
        }

        public void Imprimir()
        {
            Console.WriteLine("El nombre del empleado es: {0} y su sueldo ${1} pesos", this.Nombre, this.Sueldo);
        }

        public bool PagarImpuestos()
        {
            if (Sueldo > 30000)
                return true;
            else
                return false;
        }
    }
}
