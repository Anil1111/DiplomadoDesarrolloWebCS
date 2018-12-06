using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoDesarrolloWebCS.Unidad_1.Guia_Practica_No_4
{
    class Cuadrante
    {
        // Sentence:
        //Desarrollar una clase que represente un punto en el plano y tenga los siguientes metodos:
        //Cargar los valores de x e y || imprimir en que cuadrante se encuentra dicho punto
        private int PuntoX { get; set; }
        private int PuntoY { get; set; }

        public void Cargar(int x, int y)
        {
            this.PuntoX = x;
            this.PuntoY = y;
        }

        public void imprimir()
        {
            Console.WriteLine("El valor de x es: {0} \n El valor de y es: {1}", PuntoX, PuntoY);
        }

        public void UbicacionCuadrante()
        {
            if (PuntoX > 0 && PuntoY > 0)
                Console.WriteLine("Se encuentra en el primer cuadrante");
            if(PuntoX < 0 && PuntoY > 0)
                Console.WriteLine("Se encuentra en el segundo cuadrante");
            if (PuntoX < 0 && PuntoY < 0)
                Console.WriteLine("Se encuentra en el tercer cuadrante");
            if (PuntoX > 0 && PuntoY < 0)
                Console.WriteLine("Se encuentra en el cuarto cuadrante");
            else
                Console.WriteLine("Los Valores ingresados fueron incorecctos");
        }


    }
}
