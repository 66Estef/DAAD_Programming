// See https://aka.ms/new-console-template for more information
//GARCIA_ZEPEDA_040422
Console.WriteLine("Hello, World!");
Console.WriteLine("Ejercicios Tipo Exámen 3: Hora del día");

//Variable int para el dato numerico
int Hora;
Console.WriteLine("¿Qué hora es?");
//Leer la linea de codigo y aceptar un numero por respuesta
Hora = int.Parse(Console.ReadLine());
//Dependiendo del número, saldra el texto correspondiente. UNA SOLA VEZ


//Condición1: si el número insertado es mayor o igual a 1 y menor o igual a 6
if (Hora >= 1 && Hora <= 6)
{
    Console.WriteLine("Es de Madrugada");
}
//Condicion2: si el número insertado es mayor o igual a 6 y menor que 18
if (Hora >= 6 && Hora < 18)
{
    Console.WriteLine("Es de Día");
}
//Condicion3: si el número insertado es mayor o igual a 18 y si es menor que 24
if (Hora >= 18 && Hora < 24)
{
    Console.WriteLine("Es de Noche");
}
