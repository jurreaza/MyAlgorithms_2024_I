//  Construir un algoritmo que pida N números por pantalla, cuando el usuario ingrese un número negativo, el programa debe finalizar y mostrar en consola la cantidad total de números positivos que ingresó hasta antes de ingresarse el número negativo. 

// Declarar Variables

using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
    
     double n1;
     double np = 0;

     // Solicitar el valor

     Console.WriteLine("Ingrese la cantidad de números que desee: ");
     
     // Realizar operación 

     while(true)
        {
            n1 = Convert.ToDouble(Console.ReadLine());
            {
                if(n1 < 0)
                {
                    break; //Salir del bucle
                }
                if(n1 > 0)
                {
                    np++;
                }
            }
        }
         Console.WriteLine($"¡Ups! ha ingresado un número negativo. La cantidad de números que ingreso fueron {np}");
    }
}