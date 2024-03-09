internal class Program
{
    private static void Main(string[] args)
    {
        
        // Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un 
        // sueldo base de $XXXX. Además, recibe una comisión del 10% sobre el valor total de cada venta que 
        // realiza. El vendedor desea saber: 

        // ¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes? 
        // ¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones? 
        // ¿Cuál fue la venta que le generó la mayor comisión? 
        // ¿Cuál fue el promedio de las comisiones que recibió por cada venta?

        // Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes. 
        // El objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas. 
        // Mostrar un mensaje donde indique si ganó o no el beneficio.

        //Declaración de Variables

        double Sueldo, Venta1, Venta2, Venta3, VentaT;
        double Comision1, Comision2, Comision3;
        double ComisionP, ComisionM, STotal; 

        //Solicitar Valores

        Console.WriteLine("Ingrese el valor de su sueldo:");
        Sueldo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de la primera venta:");
        Venta1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de la segunda venta:");
        Venta2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de la tercera venta:");
        Venta3 = Convert.ToDouble(Console.ReadLine());

        //Total que recibirá por comisión de Venta 10%

        Comision1 = Venta1 * 0.10;

        Comision2 = Venta2 * 0.10;

        Comision3 = Venta3 * 0.10;

        // Venta que le generará mayor comisión, su promedio & sueldo total.

        ComisionP = (Comision1 + Comision2 + Comision3) / 3;
        ComisionM = Comision1 + Comision2 + Comision3;
        STotal = ComisionM + Sueldo;

        if ((Comision1 > Comision2) & (Comision2 > Comision3))
        {
            Console.WriteLine($"La venta que generó mayor comisión fue la venta de: {Venta1}, el promedio de su comision fue de {ComisionP} & su sueldo total es {STotal}");
        }
        else if ((Comision2 > Comision1) & (Comision1 > Comision3))
        {
            Console.WriteLine($"La venta que generó mayor comisión fue la venta de: {Venta2}, el promedio de su comision fue de {ComisionP} & su sueldo total es {STotal}");
        }
        else
        {
            Console.WriteLine($"La venta que generó mayor comisión fue la venta de: {Venta3}, el promedio de su comision fue de {ComisionP} & su sueldo total es {STotal}");
        }

        // Validación de Bonificación por Ventas & Total a Pagar

        VentaT = Venta1 + Venta2 + Venta3;

        if(VentaT >= 1000000)
        {
            Console.WriteLine("Además, usted mi estimado vendedor ganó el beneficio extra");
            
        }
        else
        {
            Console.WriteLine("Además, usted mi estimado vendedor no ganó el beneficio extra, pero en la próxima lo ganarás");
        }
    }
}