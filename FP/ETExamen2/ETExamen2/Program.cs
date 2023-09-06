// See https://aka.ms/new-console-template for more information
//GARCIA_ZEPEDA_040422
Console.WriteLine("Hello, World!");
Console.WriteLine("Ejercicios Tipo Exámen 2: Sudoku al revés");
Console.WriteLine("OPCIÓN 1");

//Variable int de 2 dígitos en forma de matríz con un espacio de 3 columnas X 3 filas
int[,] S = new int[3, 3]
{
    {3,1,2 },
    {1,3,2 },
    {1,2,3 }
};

for (int i = 0; i <= 2; i = i+1)
{
    for (int j = 0; j <= 2; j = j+1)
    {
        //Imprimir en pantalla la matriz con un rango (0 a 3)
        //Para que no salgan de forma vertical, quitamos el Line del código de Console más la coma para que tengan un espacio y no salgan tan juntos
        Console.Write(S[i,j] + ",");
    }
    Console.WriteLine();
}

Console.WriteLine("OPCIÓN 2");

//Esta opcion es lo mismo, solo que con nombres y el rango va de adelante para atrás (3 a 0)
int[,] Sudoku = new int[3, 3]
{
    {-1,-2,-3 },
    {-2,-1,-3 },
    {-3,-2,-1 }
};

for (int Fila = 2; Fila >= 0; Fila--)
{
    for(int Columna = 2; Columna >= 0; Columna--)
    {
        Console.Write(Sudoku[Fila, Columna] + ",");
    }
    Console.WriteLine();
}