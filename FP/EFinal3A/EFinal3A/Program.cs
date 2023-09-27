// See https://aka.ms/new-console-template for more information
//GARCIA_ZEPEDA_250422
Console.WriteLine("Hello, World!");
Console.WriteLine("Exámen Final 3 Opción_1: Crédito");

//Versión CORTA
string Boletinado;
double Salario;
int AñosTrabajo;

Console.WriteLine("Bienvenido, verifiquemos sus datos. ¿Usted está boletinado en su buró de crédito?");
Boletinado = Console.ReadLine();
Console.WriteLine("¿Cuál es su salario actual?");
Salario = double.Parse(Console.ReadLine());
Console.WriteLine("¿Cuál es su antigüedad en el trabajo?");
AñosTrabajo = int.Parse(Console.ReadLine());


if (Boletinado == "No" && Salario <= 5000 && AñosTrabajo > 5)
{
    Console.WriteLine("Usted cumple con los requisitos. Solicitud de crédito APROBADO. Ingrese cantidad..");
}

if (Boletinado == "Si" && Salario >= 5000 && AñosTrabajo <= 5)
{
    Console.WriteLine("Lo sentimos, Usted no cumple con los requisitos para otorgarle un crédito");
}
