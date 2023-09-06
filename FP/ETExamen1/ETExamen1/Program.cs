// See https://aka.ms/new-console-template for more information
//GARCIA_ZEPEDA_040422
Console.WriteLine("Hello, World!");
Console.WriteLine("Ejercicios Tipo Exámen 1: Switch");

//Variable int para el número del mes
int nMes;
Console.WriteLine("Mes:");
//Lectura de la línea de código para mostrar en pantalla una variable de tipo número
nMes = int.Parse(Console.ReadLine());

//Al ingresar un número, aparecera en pantalla el nombre del mes correspondiente. UNA SOLA VEZ
switch (nMes)
{
    case 0:
        Console.WriteLine("Enero");
        break;
    case 1:
        Console.WriteLine("Febrero");
        break;
    case 2:
        Console.WriteLine("Marzo");
        break;
    case 3:
        Console.WriteLine("Abril");
        break;
    case 4:
        Console.WriteLine("Mayo");
        break;
    case 5:
        Console.WriteLine("Junio");
        break;
    case 6:
        Console.WriteLine("Julio");
        break;
    case 7:
        Console.WriteLine("Agosto");
        break;
    case 8:
        Console.WriteLine("Septiembre");
        break;
    case 9:
        Console.WriteLine("Octubre");
        break;
    case 10:
        Console.WriteLine("Noviembre");
        break;
    case 11:
        Console.WriteLine("Diciembre");
        break;
    
    default:
        Console.WriteLine("INVÁLIDO");
        break;
}
