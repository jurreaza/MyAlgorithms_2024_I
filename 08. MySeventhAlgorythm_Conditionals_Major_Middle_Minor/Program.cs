         //Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y el menor de los números ingresados.

        //Declaración de Variables

        double n1, n2, n3;

        //Pedir datos al usuario

        Console.WriteLine("Ingrese el primer número: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer número: ");
        n3 = Convert.ToDouble(Console.ReadLine());

        //Validacion de datos

        if((n1 > n2) && (n2 > n3))
        {
            Console.WriteLine("El numero mayor es:" + n1);
            Console.WriteLine("El numero medio es:" + n2);
            Console.WriteLine("El numero menor es:" + n3);
        }
        else if ((n2 > n1) && (n1 > n3))
        {
            Console.WriteLine("El numero mayor es: " + n2);
            Console.WriteLine("El numero medio es: " + n1);
            Console.WriteLine("El numero menor es: " + n3);
        }
        else if ((n3 > n2) && (n2 > n1))
        {
            Console.WriteLine("El numero mayor es: " + n3);
            Console.WriteLine("El numero medio es: " + n2);
            Console.WriteLine("El numero menor es: " + n1);
        }
        else
        {
            Console.WriteLine("Hay numeros que son iguales.");
        }