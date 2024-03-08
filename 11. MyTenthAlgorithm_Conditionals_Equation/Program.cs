//Solicite los parámetros necesarios para resolver una ecuación de 2do grado por medio de la ecuación cuadrática general. 
//El algoritmo retornará las soluciones reales (x1 y x2). 
//Si la ecuación no tiene solución, debe justificar el motivo que no permite resolverla. 
//Pruebe su solución con las siguientes ecuaciones:

//- 2𝑥2−5𝑥−3=0

//- 0𝑥2+2𝑥−1=0

//- 𝑥2+𝑥+1=0

//Declaración de Variables

internal class Program
{
    private static void Main(string[] args)
    {
     
     //Declaración de Variables

        double a, b, c;
        double x, x1, x2;
    
    //Solicitar variables

        Console.WriteLine("Ingrese por favor el valor correspondiente del término cuadrático ax^2");

         a = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Ingrese por favor el valor correspondiente del término lineal bx");

          b = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Ingrese por favor el valor correspondiente del término independiente c");

          c = Convert.ToDouble(Console.ReadLine());

        // Resolución de la ecuación

        Console.WriteLine($"Ahora vamos a resolver la ecuación {a}x^2 + {b}x + {c} = 0");

        // Realizar operación

        double Discriminante = b * b - 4 * a * c;

        //Si discriminante > 0 discriminante>0, hay dos soluciones reales distintas. 
        // Si discriminante = 0 discriminante=0, hay una solución real doble.
        // Si discriminante < 0 discriminante<0, no hay soluciones reales (soluciones complejas/conjugadas).

        // Verificación de la operación

        if (Discriminante > 0)
        {
            x1 = (-b + Math.Sqrt(Discriminante)) / (2 * a);
            x2 = (-b - Math.Sqrt(Discriminante)) / (2 * a);

            Console.WriteLine($"La ecuación tiene dos soluciones reales: x1 = {x1}, x2 = {x2}");            
        }
        else if (Discriminante == 0)
        {
            x = -b / (2 * a);
            Console.WriteLine($"La ecuación tiene una soluación real: x = {x}");
        }
        else
        {
            Console.WriteLine("La ecuación no tiene soluciones reales.");
            Console.WriteLine("Motivo: Discriminante negativo.");
        }
        Console.WriteLine();
    }
}