
using System;

class Program
{
    static void Main()
    {

    // Un tren sale de la estación “A” a las 10:00 AM y viaja a una velocidad constante de 80 km/h. 
    //Un segundo tren sale de la misma estación a las 11:00 AM y viaja en la misma dirección a una velocidad 
    // constante de 100 km/h. ¿A qué hora el segundo tren alcanzará al primer tren? 
    //Mostrar esta hora en pantalla 

    //Declaración de primeras Variables

        int VTren1 = 80, VTren2 = 100;  // en km/h
        int HSTren1, HSTren2;  // 10:00 AM & 11:00 AM en minutos
        int HAlcance;
        double Dtren1, TVentaja, TNecesario;

        // Calcular la distancia recorrida por el primer tren durante la hora de ventaja

        HSTren1 = 10 * 60;
        HSTren2 = 11 * 60;
        TVentaja = HSTren2 - HSTren1;
        DTren1 = VTren1 * (TVentaja / 60.0); // Convertir minutos a horas

        // Calcular el tiempo necesario para que el segundo tren alcance al primer tren

        TNecesario = DTren1 / (VTren2 - VTren1);

        // Calcular la hora en la que el segundo tren alcanzará al primer 
        
        HAlcance = HSTren2 + (TNecesario * 60); // Convertir horas a minutos

        // Mostrar la hora en pantalla
        
        Console.WriteLine($"El segundo tren alcanzará al primer tren a las: {HAlcance} ");
    }
}