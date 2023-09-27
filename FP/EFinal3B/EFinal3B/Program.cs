// See https://aka.ms/new-console-template for more information
//GARCIA_ZEPEDA_250422
Console.WriteLine("Hello, World!");
Console.WriteLine("Exámen Final 3 Opción_2: Crédito");

//Versión EXTENDIDA
string Boletinado;
double Salario;
int AñosTrabajando;

Console.WriteLine("Bienvenido. Verifiquemos sus datos");
Console.WriteLine("¿Usted está boletinado en su buró de crédito?");
Boletinado = Console.ReadLine();

if (Boletinado == "SI")
{
    Console.WriteLine("Lo sentimos. Usted cuenta con registros negativos anteriores. No podemos otorgarle un crédito.");
}

if (Boletinado == "NO")
{
    Console.WriteLine("¿Cuál es su salario actual?");
    Salario = double.Parse(Console.ReadLine());

    if (Salario > 5000)
    {
        Console.WriteLine("Lo sentimos. Usted cuenta con fondos suficientes como para otorgarle el crédito.");
    }

    if (Salario <= 5000)
    {
        Console.WriteLine("¿Cuál es su antigüedad en el trabajo?");
        AñosTrabajando = int.Parse(Console.ReadLine());

        if (AñosTrabajando <= 5)
        {
            Console.WriteLine("Lo sentimos. Usted no cumple con los requisitos para otorgarle un crédito. Buenas tardes.");
        }

        if (AñosTrabajando > 5)
        {
            Console.WriteLine("Usted cumple con los requisitos, solicitud de crédito aprobado ¿Cuál es la cantidad que necesita?...");
        }
    }
}

