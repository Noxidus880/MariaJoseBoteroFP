namespace _4.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el sueldo");
            sueldo = Int32.Parse(Console.ReadLine());

            if (sueldo >= 3000)
            {
                // Verdadera
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else
            {
                // Falsa
                Console.WriteLine($"La persona {nombre}, no debe abonar impuestos");

                int edad = 0;

                Console.WriteLine("Ingrese su edad");
                edad = Console.ReadLine();
                if (edad >=18)
                {
                    //Verdadera 
                }
            }
        }
    }

        
        /* Crear un algoritmo que lea la edad de un usuario 
          ,si el usuario es mayor de 18,se debe mostrar el siguiente mensaje 
          : "Bienvenido a mi sitio web".De lo contrario ,mostrar el mesaje "No es apto para el contenido de este sitio web" */
        
     

