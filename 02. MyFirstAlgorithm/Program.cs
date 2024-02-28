
// Ingresar por pantalla 2 números y calcular las 4 operaciones aritméticas con dichos números. Mostrar en pantalla un mensaje de advertencia que indique que el segundo número debe ser diferente de 0. Imprimir en pantalla el resultado de cada operación.

// Declaración de Variables

int N1, N2;
double S, R, M, D;

// Leer

Console.WriteLine("Ingrese el primer valor");

// Linea 

N1 = Convert.ToInt32(Console.ReadLine()); //Todo lo que ingrese en esta linea, será tomado como un STRING.
Console.WriteLine(" ");

Console.WriteLine("Ingrese el segundo valor. Este número debe ser diferente de 0");
Console.WriteLine(" ");

N2 = Convert.ToInt32(Console.ReadLine());

// Hacer los cálculos.

S = N1 + N2;
R = N1 - N2;
M = N1 * N2;
D = N1 / N2;

// Datos de Salida

Console.WriteLine(" La suma entre " + N1 + " + " + N2 +  " es: " + S);
Console.WriteLine(" \n La resta entre " + N1 + " - " + N2 +  " es: " + R);
Console.WriteLine(" \n La Multiplicación entre " + N1 + " * " + N2 +  " es: " + M);
Console.WriteLine(" \n La División entre " + N1 + " / " + N2 +  " es: " + D);
