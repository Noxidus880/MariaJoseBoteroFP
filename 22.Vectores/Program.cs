namespace _22.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos unidimensionales
            //Vectores

            int[] numeros = new int[5];

            string[] nombres = new string[4];

            //Almacenar datos
            numeros[0] = 12;
            numeros[1] = 32;
            numeros[2] = 40;
            numeros[3] = 50;
            numeros[4] = 60;
            // numeros[5]=0; nose puede almacenar este dato porque la posición con índice 5 no existe.
            //Recuperar datos
            Console.WriteLine($"El valor almacenado en la posición 4, con índice 3 es:{numeros[3]}");
            //Recorrer para alamcenar datos
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"Ingrese el dato para la posición {i + 1},con índice {i}");
                numeros[i]=Convert.ToInt32( Console.ReadLine() );

            }
            //Otras formas de declarar e inicializar vectores
            char[] caracteres = new char[] { 'a', 'b', 'c', 'd', 'e','f','g' };
            float[] numeros2 = { 0.5f, 7.3f, 8.9f, 4.9f, 9.7f };
            
            //Recorrer para recuperar datos almacenados
            for(int i = 0;i < caracteres.Length;i++)
            {
                Console.WriteLine($"P:{i+1}-I:{i}: {caracteres[i]}");
            }
            for(int i=0;i<numeros2.Length;i++)
            {
                Console.Write($"{numeros2[i]} | ");
            }
            //Ejercicio con nombres
            for(int i=0; i<nombres.Length;i++)
            {
                Console.WriteLine($"Ingrese un nombre para la posición {i + 1},con índice {i}");
                nombres[i]=Console.ReadLine();
            }
        }
    }
}
