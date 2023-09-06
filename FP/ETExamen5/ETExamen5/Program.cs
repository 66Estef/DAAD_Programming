// See https://aka.ms/new-console-template for more information
//GARCIA_ZEPEDA_040422
Console.WriteLine("Hello, World!");
Console.WriteLine("Ejercicios Tipo Exámen 5: Compra de Artículos");

//Arreglo para variables que guarden los datos ingresados en la consola
Articulos[] articulo;

//Variables para cada tipo de dato
string NombreDelArticulo = " ";
int PrecioDelArticulo;
int NumeroDeArticulos;
string Impuesto = " ";

//Variable para el precio con o sin impuesto
double PrecioTotal = 0;

//Variable indice y clasificador de los diferentes productos
int Contador = 0;
int NumeroProductosLlevar;

//Variable del pago total de la compra
double Total = 0;


Console.WriteLine("Buenas tardes ¿Cuántos productos va a adquirir?");
//Ingresar las categorias de productos diferentes a comprar
NumeroProductosLlevar = int.Parse(Console.ReadLine());
articulo = new Articulos[NumeroProductosLlevar];

//Ciclo que el programa repetira hasta notar la cantidad de los diferentes productos ingresado
do
{
    Console.WriteLine("Descripción del artículo" + (Contador + 1) + ". Nombre:");
    NombreDelArticulo = Console.ReadLine();
    Console.WriteLine("Precio:");
    PrecioDelArticulo = int.Parse(Console.ReadLine());
    Console.WriteLine("Cantidad de artículos:");
    NumeroDeArticulos = int.Parse(Console.ReadLine());
    Console.WriteLine("¿Tiene impuesto?: Si / No");
    Impuesto = Console.ReadLine();

    if (Impuesto == "Si")
    {
        PrecioTotal = (NumeroDeArticulos * PrecioDelArticulo) * 1.10;
    }
    else
    {
        PrecioTotal = (NumeroDeArticulos * PrecioDelArticulo);
    }

    //Guardar datos del producto
    articulo[Contador].nombrearticulo = NombreDelArticulo;
    articulo[Contador].precio = PrecioDelArticulo;
    articulo[Contador].cantidad = NumeroDeArticulos;
    articulo[Contador].impuesto = Impuesto;
    articulo[Contador].total = PrecioTotal;

    //En caso de haber más productos, el indice aumentara y dara espacio para la informacion del nuevo producto esperado
    Contador++;

} while (Contador < NumeroProductosLlevar);

//Una vez guardados los datos, lo reflejamos en pantalla
for (int i = 0;i < NumeroProductosLlevar;i++)
{
    Console.WriteLine("***** Resumen de su compra*****");
    Console.WriteLine("Artículo:" + articulo[i].nombrearticulo);
    Console.WriteLine("Precio:" + articulo[i].precio);
    Console.WriteLine("Cantidad:" + articulo[i].cantidad);
    Console.WriteLine("Precio Total:" + articulo[i].total);
    Total = Total + articulo[i].total;
}

Console.WriteLine("Total a pagar:" + Total.ToString());

//Declaración de subvariables para guardar los datos ingresados en la pantalla al inicio
struct Articulos
{
    public string nombrearticulo;
    public double precio;
    public int cantidad;
    public string impuesto;
    public double total;
}
