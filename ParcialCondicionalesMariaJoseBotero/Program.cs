namespace ParcialCondicionalesMariaJoseBotero
{
    internal class Program
    {
        /*En una empresa de confecciones, al finalizar cada año se realiza una evaluación de desempeño para todos los empleados. Con base en esta evaluación, los trabajadores pueden obtener aumentos salariales. Las calificaciones posibles son limitadas y se consideran ciertos criterios para calcular el porcentaje de aumento.

Requerimientos del programa

Se debe desarrollar un programa en C# que permita (70%):

Ingresar los siguientes datos del empleado:

Nombre del empleado.
Número de años trabajados en la empresa.
Calificación del año actual (0.0, 0.4, 0.6, 1.0).
Calificación del año anterior (debe ser uno de los mismos valores anteriores)*/
        static void Main(string[] args)
        {
            Console.WriteLine($"Ingrese su nombre");
            Console.ReadLine();
            Console.WriteLine($"Ingrese cuantos años lleva trabajando en la empresa");
            Console.ReadLine();

            float calificacionActual = 0f;
            float calificacionAntigua = 0f;
            float calificacion1 = 0.0f;
            float calificacion2 = 0.4f;
            float calificacion3 = 0.6f;
            float calificacion4 = 1.0f;

            float promedioCalificacion = (calificacionAntigua + calificacionActual) / 2;

            int añosTrabajados = 0;
            float PorcentajeAumentoSalario = 0.0f;
            



            Console.WriteLine($"Ingresar la {calificacionActual} del año actual");
            Console.ReadLine();
  
            
            if (calificacionActual!=calificacion1 && calificacionActual != calificacion2 && calificacionActual != calificacion3 && calificacionActual != calificacion4)
            {
                Console.WriteLine($"El valor ingresado para la calificación no es válido");
            }
            else
            {
                Console.WriteLine($"Ingresar la {calificacionAntigua} del año anterior");
                Console.ReadLine();
                if (calificacionAntigua != calificacion1 && calificacionAntigua != calificacion2 && calificacionAntigua != calificacion3 && calificacionAntigua != calificacion4)
                {
                    Console.WriteLine($"El valor ingresado para la calificación no es válido");
                }
                else    //3. Calcular el promedio de las dos calificaciones (año actual y anterior).
                {
                    Console.WriteLine($"El promedio de sus calificaciones es {promedioCalificacion}");
                }

                /*4. Según el número de años trabajados y el promedio de calificación, determinar el porcentaje de aumento salarial utilizando las siguientes reglas:

                añosTrabajados < 1 = 0 %
                añosTrabajados > 5 = 30 %
                0 < añosTrabajados <= 5 y 0 <= promedioCalificación < 0.4 = 5 %
                0 < añosTrabajados <= 5 y 0.4 <= promedioCalificación < 0.6 = 10 %
                0 < añosTrabajados <= 5 y 0.6 <= promedioCalificación <= 1.0 = 20 % */

                Console.WriteLine($"Ingrese los años que lleva trabajando en la empresa");
                Console.ReadLine();
                if (añosTrabajados < 1)
                {
                    Console.WriteLine($"Su porcentaje de aumento salarial es 0%");
                }
                if (añosTrabajados>5)
                {
                    Console.WriteLine($"Su porcentaje de aumento salarial es 30%");
                }

            }






        }
    }
}
