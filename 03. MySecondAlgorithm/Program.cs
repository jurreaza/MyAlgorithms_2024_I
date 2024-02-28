// Realizar un algoritmo que me pida 03 números por pantalla, con el primer número hallar el cuadrado, con el segundo número hallar la raíz cuadrada y con el tercer número hallar la raíz cúbica. Mostrar en pantalla los 03 resultados aritméticos. Recuerde concatenar bien los strings para mostrar un mensaje bonito.

// Declarar las variables 

Double N1, N2, N3, C, RC, RCU;

// Pedir al usuario que ingrese 03 números.

Console.Write("Ingrese el primer número: \n");

N1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el segundo número: \n");

N2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tercer número: \n");

N3 = Convert.ToDouble(Console.ReadLine());

// Calcular el cuadrado, la raíz cuadrada & la raíz cúbica.

C = Math.Pow(N1, 2);
RC = Math.Sqrt(N2);
RCU = Math.Cbrt(N3);

// Mostrar los resultados en pantalla.

Console.WriteLine($" El cuadrado de {N1} es: {C}");
Console.WriteLine($" La raíz cuadrada de {N2} es: {RC}");
Console.WriteLine($" La raíz cúbica de {N3} es: {RCU}");