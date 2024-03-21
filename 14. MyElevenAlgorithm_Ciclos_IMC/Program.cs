/*Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:

- Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.

- Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable

- Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso

- Si el IMC es mayor de 29.9 entonces tiene obesidad.

Mostrar en pantalla la categoría de cada uno de los pacientes. La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcular */

using System;

class Program
{
    static void Main(string[] args)
    {
        bool calcularNuevamente = true;
        double peso, altura, imc;
        string categoria, respuesta;

        while (calcularNuevamente)
        {
            Console.WriteLine("Ingrese el peso (en kg) del paciente:");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura (en metros) del paciente:");
            altura = double.Parse(Console.ReadLine());

            imc = CalcularIMC(peso, altura);
            categoria = CalcularCategoriaIMC(imc);

            Console.WriteLine($"El IMC del paciente es: {imc:F2}");
            Console.WriteLine($"El paciente está en la categoría de: {categoria}");

            Console.WriteLine("¿Desea calcular el IMC de otro paciente? (s/n)");
            respuesta = Console.ReadLine();
            calcularNuevamente = (respuesta.ToLower() == "s");
        }
    }

    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    static string CalcularCategoriaIMC(double imc)
    {
        if (imc < 18.5)
            return "Peso insuficiente";
        else if (imc >= 18.5 && imc <= 24.9)
            return "Peso saludable";
        else if (imc >= 25.0 && imc <= 29.9)
            return "Sobrepeso";
        else
            return "Obesidad";
    }
}
