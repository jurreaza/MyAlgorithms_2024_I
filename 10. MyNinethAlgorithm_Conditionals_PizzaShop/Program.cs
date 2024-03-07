

using System.Reflection.PortableExecutable;

internal class Program
{
    private static void Main(string[] args)
    {
        
        // La pizzería Bella Napoli ofrece pizzas vegetarianas y no vegetarianas a sus clientes.
        // Los ingredientes para cada tipo de pizza aparecen a continuación.
        // Ingredientes vegetarianos: Pimiento y tofu.
        // Ingredientes no vegetarianos: Peperoni, Jamón y Salmón.
        // Escribir un programa en C# que pregunte al usuario si quiere una pizza vegetariana o no,
        // y en función de su respuesta le muestre un menú con los ingredientes disponibles para que elija.
        // Solo se puede elegir un ingrediente además de la mozzarella y el tomate que están en todas las pizzas.
        // Al final se debe mostrar por pantalla si la pizza elegida es vegetariana o no y todos los ingredientes que lleva.


        //Declaración de Variables
        
        int Pizza;
        int Adicional;
        String Veg = "1. Pimiento & 2. Tofu", NoVeg = "1. Peperoni, 2. Jamón & 3. Salmón"; 

        // Solicitar pedido

        Console.WriteLine("Ingrese el tipo de pizza que desea. Ingrese 1 para pizza VEGETARIANA o Ingrese 2 para pizza NO VEGETARIANA");
        Pizza = Convert.ToInt32(Console.ReadLine());

        if (Pizza == 1)
        {
          Console.WriteLine($"Ha seleccionado pizza VEGETARIANA. Ingredientes: {Veg}");
          Console.WriteLine("Ahora ingrese el número correspondiente para que seleccione un ingrediente adicional: ");

          Adicional = Convert.ToInt32(Console.ReadLine());

            if(Adicional == 1)
            {
                Console.WriteLine($"Su deliciosa Pizza es VEGETARIANA & contiene {Veg} & como ingrediente adicional PIMIENTO ");
            }
            if(Adicional == 2)
            {
                Console.WriteLine($"Su deliciosa Pizza es VEGETARIANA & contiene {Veg} & como ingrediente adicional TOFU ");
            }
            if(Adicional == 3)
            {
                Console.WriteLine($"Su deliciosa Pizza es VEGETARIANA & contiene {Veg} & como ingrediente adicional PEPERONI ");
            }
            if(Adicional == 4)
            {
                Console.WriteLine($"Su deliciosa Pizza es VEGETARIANA & contiene {Veg} & como ingrediente adicional JAMÓN ");
            }
            if(Adicional == 5)
            {
                Console.WriteLine($"Su deliciosa Pizza es VEGETARIANA & contiene {Veg} & como ingrediente adicional SALMÓN ");
            }

        }
        else if (Pizza == 2)
        {
          Console.WriteLine("Estos son los ingredientes que contiene la pizza: ");  
          Console.WriteLine($"Ha seleccionado pizza NO VEGETARIANA. Ingredientes: {NoVeg}");

          Console.WriteLine("Ahora ingrese el número correspondiente para que seleccione un ingrediente adicional: ");

          Adicional = Convert.ToInt32(Console.ReadLine());

            if(Adicional == 1)
            {
                Console.WriteLine($"Su deliciosa Pizza NO es VEGETARIANA & contiene {NoVeg} & como ingrediente adicional PIMIENTO ");
            }
            if(Adicional == 2)
            {
                Console.WriteLine($"Su deliciosa Pizza es VEGETARIANA & contiene {NoVeg} & como ingrediente adicional TOFU ");
            }
            if(Adicional == 3)
            {
                Console.WriteLine($"Su deliciosa Pizza es VEGETARIANA & contiene {NoVeg} & como ingrediente adicional PEPERONI ");
            }
            if(Adicional == 4)
            {
                Console.WriteLine($"Su deliciosa Pizza es VEGETARIANA & contiene {NoVeg} & como ingrediente adicional JAMÓN ");
            }
            if(Adicional == 5)
            {
                Console.WriteLine($"Su deliciosa Pizza es VEGETARIANA & contiene {NoVeg} & como ingrediente adicional SALMÓN ");
            }

        }
        else
        {
          Console.WriteLine("La opción ingresada es incorrecta. Por favor ingrese 1 para Pizza VEGETARIANA o 2 para Pizza no VEGETARIANA.");
        }
    }
}