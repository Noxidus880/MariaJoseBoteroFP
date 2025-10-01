using System.Security.Cryptography;

namespace TallerParcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Algoritmo que permita calcular el promedio de calificaciones, el algoritmo
            le permitirá al usuario, introducir tantas calificaciones como así desee,
en el momento en que seleccione que no desea continuar capturando
calificaciones, el algoritmo debe presentar el promedio de las
calificaciones capturadas previamente*/

            int calificacion = 0;
            int acumulador = 0;
            int contador = 1;
            float promedio = 0f;
            string respuesta = "";
          
                do
                {
                    Console.WriteLine($"Ingrese una calificación");
                    calificacion = Convert.ToInt32(Console.ReadLine());
                   contador=
                    Console.WriteLine($"¿Desea ingresar otra calificación?, s:si , n:no");
                    respuesta = Console.ReadLine();
                } while (respuesta != "n");
          
            
            

            promedio = acumulador / contador;
            Console.WriteLine($"Su promedio es {promedio}");




        }
    }
}
