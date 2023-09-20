// See https://aka.ms/new-console-template for more information
//GARCIA_ZEPEDA_040422
Console.WriteLine("Hello, World!");
Console.WriteLine("Ejercicios Tipo Exámen 6: Juego Temple Run");

//Variables
int Castigo; //daño
int Premio;
string Respuesta;
double Vida;

//Al iniciar el juego, no hay premio ni castigo
Premio = 0;
Castigo = 0;
Respuesta = " ";
//Para este ejmplo inicias con 12 vidas pero puedes bajarlo a 5 para más dificíl
Vida = 12;

Random aleatorio = new Random();

Console.WriteLine("¡¡EMPECEMOS A JUGAR!!");

//Ciclo de repetición
do
{
    //Color que tendrá el texto
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Tienes" + Vida + "vida(s)");
    Console.ResetColor();

    //Estas 3 lineas podemos suspenderlas para no quitarle vidas cada que decides continuar
    Vida = Vida - 1;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Consumiste 1 vida");

    //Reseteamos el color para volver al default, a menos que lo cambiemos segun haya premio ocastigo
    Console.ResetColor();

    //Variable que saldra a la suerte en la maquina, con rango de 0 a 2
    Premio = aleatorio.Next(0, 2);

    //Si tienes suerte, ganaras vidas
    if (Premio == 2)
    {
        //Cambiamos el color de la suerte
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("¡¡Yujuu, un premio!!");
        Vida = Vida + 3;
        Console.WriteLine("Has ganado ¡3 vidas!");
        Console.WriteLine(" + + + + + + + + ");
        Console.ResetColor();
    }

    //Variable que saldra la suerte en la computadora, rango de 0 a 2
    Castigo = aleatorio.Next(0, 2);

    if (Castigo == 1)
    {
        //Cambio de color para marcar el daño
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("¡OH NO! un obstáculo. :o");
        Vida = Vida - 4;
        Console.WriteLine("Perdiste 4 vidas :(");
        Console.WriteLine(" - - - - - - - - ");
        Console.ResetColor();

        //Si se acaban las vidas, termina el juego
        if (Vida <= 0)
        {
            Console.WriteLine("Terminó el juego :(");
            break;
        }
    }

    //Despues del premio o castigo, el contador vidas se actualizara
    //Remarcamos con otro color
    Console.ForegroundColor= ConsoleColor.Magenta;
    Console.WriteLine("Vidas restantes: " + Vida);
    Console.ResetColor();

    //Pregunta al usuario
    Console.WriteLine("¿Quieres seguir jugando?");
    Console.WriteLine(" SI / NO ");

    //Ingresa el dato y leera la información
    Respuesta = Console.ReadLine();

    //Si el usuario escribe no, el juego terminara sin importar tus vidas. Boton Salir
    if (Respuesta == "No")
    {
        Console.WriteLine("Adios :)");
    }

    Console.WriteLine(" * * * * ");

    //El ciclo de consumo, premio y castigo se repetira mientras el usuario diga que si o las vidas sean mayores a 0
} while ((Respuesta == "Si") && (Vida > 0)); 