// See https://aka.ms/new-console-template for more information
//GARCIA_ZEPEDA_100222
Console.WriteLine("Hello, World!");
Console.WriteLine("Práctica B_1: Ejercicios Aritméticos");

//Variables1
double Respuesta1;
double Respuesta2;
double Respuesta3;
double Respuesta4;
double Respuesta5;
double Respuesta6;
double Respuesta7;
double Respuesta8;

//La diagonal significa división, el asterisco multiplicación
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 1: 1 + (3 / 2) = ? ");
//Solución
Console.ResetColor();
Respuesta1 = 1 + (3 / 2);
Respuesta1 = 1 + (1.5);
Console.WriteLine("Respuesta:" + Respuesta1);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operacion 2: 2 - (3 * 4) = ? ");
//Solución
Console.ResetColor();
Respuesta2 = 2 - (3 * 4);
Respuesta2 = 2 - (12);
Console.WriteLine("Respuesta:" + Respuesta2);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 3: ((2.0 / 3.0) / 4.0) = ? ");
//Solución
Console.ResetColor();
Respuesta3 = ((2.0 / 3.0) / 4.0);
Console.WriteLine("Respuesta:" + Respuesta3);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 4: (4 / 3) * (2 / 5) = ? ");
//Solución
Console.ResetColor();
Respuesta4 = (4 / 3) * (2 / 5);
Respuesta4 = (1.33) * (0.4);
Console.WriteLine("Respuesta:" + Respuesta4);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 5: (6 * 3) / (4 * 5) = ? ");
//Solución
Console.ResetColor();
Respuesta5 = (6 * 3) / (4 * 5);
Respuesta5 = (18.0) / (20.0);
Console.WriteLine("Respuesta:" + Respuesta5);


//Exponencial
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 6: 1 - 1 + e^-12 = ?");
//Solución
Console.ResetColor();
Respuesta6 = 1 - 1 + Math.Exp(-12);
Console.WriteLine("Respuesta:" + Respuesta6);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 7: 1 + e^-12 - 1 = ? ");
//Solución
Console.ResetColor();
Respuesta7 = 1 + Math.Exp(-12) - 1;
Console.WriteLine("Respuesta:" + Respuesta7);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 8: 4 * 3 ^ 2 = ? ");
//Solución
Console.ResetColor();
Respuesta8 = 4.0 * Math.Pow(3.0, 2.0);
Console.WriteLine("Respuesta:" + Respuesta8);


//Variables2
double Respuesta9;
double Respuesta10;
double Respuesta11;
double Respuesta12;
double Respuesta13;
double Respuesta14;
double Respuesta15;
double Respuesta16;
double Respuesta17;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 9: 1 + 3 ^ 2 = ? ");
//Solución
Console.ResetColor();
Respuesta9 = 1 + (Math.Pow(3, 2));
Console.WriteLine("Respuesta:" + Respuesta9);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 10: 5 / 2 ^ 3 = ? ");
//Solución
Console.ResetColor();
Respuesta10 = (5.0 / (Math.Pow(2, 3)));
Respuesta10 = (5.0 / (8));
Console.WriteLine("Respuesta:" + Respuesta10);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 11: (3 / 10 ^ 3) * 7 = ? ");
//Solución
Console.ResetColor();
Respuesta11 = (3 / (Math.Pow(10, 3))) * 7;
Respuesta11 = (3 / (1000)) * 7;
Respuesta11 = (0.003) * 7;
Console.WriteLine("Respuesta:" + Respuesta11);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 12: ((2 ^ 3) ^ 4) = ? ");
//Solución
Console.ResetColor();
Respuesta12 = (Math.Pow(8, 4));
Console.WriteLine("Respuesta:" + Respuesta12);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 13: 2 ^ (3 * 4) = ? ");
//Solución
Console.ResetColor();
Respuesta13 = (Math.Pow(2, (3 * 4)));
Respuesta13 = (Math.Pow(2, 12));
Console.WriteLine("Respuesta:" + Respuesta13);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 14: (2.0 / (3.0 / 3.0) = ? ");
//Solución
Console.ResetColor();
Respuesta14 = (2.0 / (3.0 / 3.0));
Respuesta14 = (2.0 / 1.0);
Console.WriteLine("Respuesta:" + Respuesta14);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 15: (512 - 282) / ((47 * 48) + 5) = ? ");
//Solución
Console.ResetColor();
Respuesta15 = (512 - 282) / ((47 * 48) + 5);
Respuesta15 = (512 - 282) / ((2256) + 5);
Respuesta15 = (512 - 282) / 2261;
Respuesta15 = 230.0 / 2261.0;
Console.WriteLine("Respuesta 15:" + Respuesta15);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 16: Residuo de 12 % 3 = ? ");
//Solución
Console.ResetColor();
Respuesta16 = 12 % 3;
Console.WriteLine("Respuesta 16:" + Respuesta16);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Operación 17: Residuo de 12 % 7 = ? ");
//Solución
Console.ResetColor();
Respuesta17 = 12 % 7;
Console.WriteLine("Respuesta:" + Respuesta17);