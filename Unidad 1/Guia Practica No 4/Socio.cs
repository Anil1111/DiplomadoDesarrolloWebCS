using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_No_4
{
    class Socio
    {
        //Sentence:
        //Plantear una clase Club y otra clase Socio. L aclase Socio debe tener los siguientes atributos privados:
        //nombre y la antiguedad en el club (en años). En el constructor pedir la carga del nombre y su antiguedad.
        //La clase Club debe tener como atributo 3 objetos de la clase Socio. Definir una responsabilidad para imprimir el nombre del 
        //socio con mayor antiguedad en el club.

        private string Nombre { get; set; }
        private  int Antiguedad { get; set; }

        public Socio( string nombre, int antiguedad)
        {
            this.Nombre = nombre;
            this.Antiguedad = antiguedad;
        }

        public int ObtenerAntiguedad()
        {
            return this.Antiguedad;
        }
        public string ObtenerNombre()
        {
            return this.Nombre;
        }
    }

    class Club
    {
        private Socio socio1, socio2, socio3;
        string prestigio = null;

        public Club()
        {
            socio1 = new Socio("Pedro", 5);
            socio2 = new Socio("Maria", 7);
            socio3 = new Socio("José", 10);
        }

        public void SocioMayorPrestigio()
        {
            if (socio1.ObtenerAntiguedad() > socio2.ObtenerAntiguedad() && socio1.ObtenerAntiguedad() > socio3.ObtenerAntiguedad())
                prestigio = socio1.ObtenerNombre();
            if (socio2.ObtenerAntiguedad() > socio1.ObtenerAntiguedad() && socio2.ObtenerAntiguedad() > socio3.ObtenerAntiguedad())
                prestigio = socio2.ObtenerNombre();
            if (socio3.ObtenerAntiguedad() > socio2.ObtenerAntiguedad() && socio3.ObtenerAntiguedad() > socio1.ObtenerAntiguedad())
                prestigio = socio3.ObtenerNombre();
            Console.WriteLine("El socio con mayor prestigio es: {0}", prestigio);
        }
    }
}
