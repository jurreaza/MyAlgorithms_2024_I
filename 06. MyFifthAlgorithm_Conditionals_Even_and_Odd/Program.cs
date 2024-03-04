// Construir un programa que pida un número y luego diga si este número es par o no. 

// Declarar Variables

internal class Program
{
    private static void Main(string[] args)
    {
        double N;
        string M = "El número ingresado es: ";

        // Pedir los datos
        Console.WriteLine("Ingrese solamente números positivos \n");
        Console.WriteLine("Ingrese el número:");
        N = Convert.ToDouble(Console.ReadLine());

        // Operación

        if (N % 2 == 0)
        {
            Console.WriteLine($"{M} Par. ");
        }
        else
        {
            Console.WriteLine($"{M} Impar.");
        }
    }
}


