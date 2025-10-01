namespace TallerMatricesYVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
            pantalla la suma de los elementos de cada columna*/
            int[,] numeros= new int [10,20];//El rango va a ser de 200 posiciones.
            Random rnd= new Random();
            int suma = 0;
            
            
            int num = rnd.Next(10, 35);
            for (int i = rnd.Next(10,35); i<35 ; i++)
            {
                for(int j = rnd.Next(10,35);j<35 ; j++)
                {
                    suma = numeros[10,20] + num
                    Console.WriteLine($"La suma de la columna {j} es {suma}");

                }


            }
            
          

            
        }

        


        
    }
}
