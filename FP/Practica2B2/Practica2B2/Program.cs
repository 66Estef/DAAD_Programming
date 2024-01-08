// See https://aka.ms/new-console-template for more information
//GARCIA_ZEPEDA_100222
Console.WriteLine("Hello, World!");
Console.WriteLine("Práctica B_2: Ejercicios de Comparación");

//Variables
int comp1 = 8;
int comp2 = 8;
int comp3 = 4;
int comp4 = 9;
int comp5 = 3;
string comp6 = "Hola";
string comp7 = "hola";
string comp8 = "Perro";
string comp9 = "Gato";
string respuesta = "ES DIFERENTE";
bool Comparacion = true;


Console.ForegroundColor= ConsoleColor.Magenta;
Console.WriteLine("Ejercicio 1: Comparar 8 y 8 ");
//Solución
Console.ResetColor();
if (comp1 == comp2)
{
    Console.WriteLine(Comparacion);
}


Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Ejercicio 2: Comparar 8 > 4 ");
//Solución
Console.ResetColor();
if (comp1 > comp3)
{
    Console.WriteLine(Comparacion);
}


Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Ejercicio 3: Comparar 9 < 3 ");
//Solución
Console.ResetColor();
if(comp4 == comp5)
{
    Console.WriteLine(Comparacion);
}
else
{
    Console.WriteLine(false);
}


Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Ejercicio 4: Comparar Hola y hola ");
//Solución
Console.ResetColor();
if(comp6 == comp7)
{
    Console.WriteLine(Comparacion);
}
else
{
    Console.WriteLine(false);
}


Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Ejercicio 5: Comparar Perro y Gato");
//Solución
Console.ResetColor();
if(comp8 == comp9)
{
    Console.WriteLine(Comparacion);
}
else
{
    Console.WriteLine(respuesta);
}
