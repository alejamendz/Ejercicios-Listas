List<string> Productos =new List<string>();

int opcion;
do
{
    Console.Clear();

    Console.WriteLine("PRODUCTOS TIENDA");
    Console.WriteLine("1. Agregar un producto.");
    Console.WriteLine("2. Mostrar todos los productos registrados.");
    Console.WriteLine("3. Buscar un producto por su nombre.");
    Console.WriteLine("4. Buscar un producto por su nombre.");
    Console.WriteLine("5. Eliminar un producto.");
    Console.WriteLine("6. Mostrar la cantidad total de productos registrados.");
    Console.WriteLine("7. Salir");

    Console.WriteLine("Seleccione una opcion: ");
    opcion=Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el nombre del producto:");
            string producto= Console.ReadLine();    
            Productos.Add(producto);

            Console.WriteLine("¡Se agrego el producto!");
            break;

        case 2:
            Console.WriteLine("LISTADO DE PRODUCTOS\n");
            if(Productos.Count==0)
            {
                Console.WriteLine("No hay ningun producto registrado");
            }
            else
            {
                int contador = 1;
                foreach(string productoss in Productos)
                {
                    Console.WriteLine($"{contador}. {productoss}");
                    contador++;
                }   
            }
            break;
    }

    if (opcion != 7)
    {
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }

} while (opcion!=7);
