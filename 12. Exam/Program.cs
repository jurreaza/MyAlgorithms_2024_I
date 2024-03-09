
// Un tren sale de la estación “A” a las 10:00 AM y viaja a una velocidad constante de 80 km/h. 
//Un segundo tren sale de la misma estación a las 11:00 AM y viaja en la misma dirección a una velocidad 
// constante de 100 km/h. ¿A qué hora el segundo tren alcanzará al primer tren? 
//Mostrar esta hora en pantalla 

//Declaración de primeras Variables

double VelTren1 = 80;  // en km/h
double VelTren2 = 100; // en km/h
double HSalTren1 = 10 * 60;  // 10:00 AM en minutos
double HSalTren2 = 11 * 60;  // 11:00 AM en minutos

// Calcular la distancia recorrida por el primer tren durante la hora de ventaja
double TVentaja = HSalTren2 - HSalTren1;
double DTren1 = VTren1 * (TVentaja / 60); // Convertir minutos a horas

// Calcular el tiempo necesario para que el segundo tren alcance al primer tren
double TNecesario = DTren1 / (VelTren2 - VelTren1);

// Calcular la hora en la que el segundo tren alcanzará al primer tren
double HAlcance = HSalTren2 + (TNecesario * 60); // Convertir horas a minutos

// Mostrar la hora en pantalla
Console.WriteLine("El segundo tren alcanzará al primer tren a las: " + TimeSpan.FromMinutes(HAlcance).ToString("hh:mm"));
