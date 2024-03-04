internal class Program
{
    private static void Main(string[] args)
    {

        // Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números ingresado;

        //Declarar Variables

        double N1, N2, N3;
        string M = "El número mayor es: ";

        //Pedir Valores

        Console.WriteLine("Ingrese solamente valores positivos.");
        Console.WriteLine("Primer número: ");
        N1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Segundo número: ");
        N2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Tercer número: ");
        N3 = Convert.ToDouble(Console.ReadLine());

        // Validación

        if (N1 > N2 && N1 > N3)
        {
            Console.WriteLine($"{M} {N1}");
        }
        else if (N2 > N1 && N2 > N3)
        {
            Console.WriteLine($"{M} {N2}");
        }
        else
        {
            Console.WriteLine($"{M} {N3}");
        }
    }
}