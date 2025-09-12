namespace _21.ForEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;

            for(int i=1;i<=5;i++)
            {
                acumulador += i;
            }
            Console.WriteLine($"La suma de los primeros cinco números enteros es {acumulador}");
        }
    }
}
