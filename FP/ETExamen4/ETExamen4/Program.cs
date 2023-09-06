// See https://aka.ms/new-console-template for more information
//GARCIA_ZEPEDA_040422
Console.WriteLine("Hello, World!");
Console.WriteLine("Ejercicios Tipo Exámen 4: Ecuación de segundo grado");

//3 Variables double para numeros con decimales o no enteros
double a, b, c;
a = 6;
b = -5;
c = 1;

//2 Variables para las 2 alternativas de la ecuación
double X1, X2;

Console.WriteLine("Ecuación a resolver: 6x^2 - 5x + 1 = 0");
//Procedimiento
X1 = - b + (Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / (2 * a));
X2 = - b - (Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / (2 * a));

//Respuesta
Console.WriteLine(X1);
Console.WriteLine(X2);
