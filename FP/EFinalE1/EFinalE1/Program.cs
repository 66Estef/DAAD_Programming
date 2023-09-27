// See https://aka.ms/new-console-template for more information
//GARCIA_ESTEFANNIA_250422
Console.WriteLine("Hello, World!");
Console.WriteLine("Exámen Final 1: Matrices");

//Variables
int[,] Matriz2 = new int[,]
{
    {5,6},
    {7,8},
};
for (int f = 0; f <= 1; f++)
{
    for (int c = 0; c <= 1; c++)
    {
        Console.WriteLine(Matriz2[f, c]);
    }
    Console.WriteLine();
}

int[,] Matriz1 = new int[,]
{
    {1,2},
    {3,4},
};
for (int fila = 0; fila <= 1; fila++)
{
    for (int columna = 0; columna <= 1; columna++)
    {
        Console.WriteLine(Matriz1[fila, columna]);
    }
    Console.WriteLine();
}
