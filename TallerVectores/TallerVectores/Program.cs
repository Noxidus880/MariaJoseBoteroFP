using System.ComponentModel.Design;

namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*. Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego 
           encuentre y muestre el valor máximo y mínimo de los números ingresados.*/
            int[] vector = new int [15];
            Random rnd = new Random();
            int numeroMenor = 0;
            int numeroMayor = 0;
           

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(0, 50);
                Console.Write(vector[i] + ", ");

            }

            numeroMenor = vector[0];
            Console.WriteLine("Numero menor inicial es " + vector[0]);
            numeroMayor = vector[0];
            Console.WriteLine($"El número mayor inicial es {vector[0]}");
            
            for (int i = 1; i < vector.Length; i++)
            {
                if (numeroMenor <= vector[i])
                {
                    //Console.WriteLine("El número menor sigue siendo " + numeroMenor);
                }
                else
                {
                    numeroMenor = vector[i];
                    //Console.WriteLine("Ahora el número menor es " + numeroMenor);
                }
                
                
                
                if (numeroMayor >= vector[i])
                {
                    //Console.WriteLine($"El número mayor sigue siendo {numeroMayor}");
                }
                else
                {
                    numeroMayor = vector[i];
                    //Console.WriteLine($"Ahora el número mayor es {numeroMayor}");
                }



            }

            Console.WriteLine("El número mayor es " + numeroMayor + " Y el menor es: " + numeroMenor);


        }
    }
}
