

internal class Program
{
    private static void Main(string[] args)
    {
        // Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos. 

        //Declaración de Variables:
     
        double S1, S2, S3;
        string M = "Se puede construir un triángulo";

        // Pedir los datos:

        Console.Write("Ingrese solo valores positivos \n");
        Console.Write("\nIngrese el primer Segmento: ");
        S1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo Segmento: ");
        S2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el tercer Segmento: ");
        S3 = Convert.ToDouble(Console.ReadLine());

        //Validar

        if(((S1 + S2) > S3) && ((S1 + S3) > S2) && ((S2 + S1) > S3))
        {
            Console.WriteLine(String.Format($"Si {M}"));
        }
        else
        {
            Console.WriteLine(String.Format($"No {M}"));
        }
    }
}