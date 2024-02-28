// Lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos.

//Datos de Entrada: Son 04 Variables. Declaración de Variables.

double X1, X2, Y1, Y2, D;

// Solicitud de datos por pantalla:

Console.Write("Ingre el valor de X1: ");

X1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingre el valor de Y1: ");

Y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingre el valor de X2: ");

X2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingre el valor de Y2: ");

Y2 = Convert.ToDouble(Console.ReadLine());

// Hacer los Calculos

D = Math.Sqrt(Math.Pow((X2-X1), 2) + (Math.Pow((Y2-Y1), 2)));

// Dato de Salida

Console.WriteLine($"La distancia entre los pares ordenados ({X1} , {Y1}) & ({X2} , {Y2}) es = {D}");

