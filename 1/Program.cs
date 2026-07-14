List<string> Productos =new List<string>();

int opcion;
do
{
    Console.Clear();

    Console.WriteLine("PRODUCTOS TIENDA");
    Console.WriteLine("1. Agregar un producto.");
    Console.WriteLine("2. Mostrar todos los productos registrados.");
    Console.WriteLine("3. Buscar un producto por su nombre.");
    Console.WriteLine("4. Modificar el nombre de un producto existente.");
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
            Console.WriteLine("LISTADO DE PRODUCTOS");
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

        case 3:
            Console.WriteLine("Ingrese el nombre del producto que desea buscar: ");
            string buscar= Console.ReadLine();

            if (Productos.Contains(buscar))
            {
                Console.WriteLine("El producto si existe");
                Console.WriteLine($"Posicion: {Productos.IndexOf(buscar)}");
            }
            else
            {
                Console.WriteLine("El producto no existe");
            }
            break;

        case 4:
            Console.Write("Ingrese el prodcuto que desea modificar: ");
            string modificar = Console.ReadLine();

            if (Productos.Contains(modificar))
            {
                int posicion = Productos.IndexOf(modificar);

                Console.Write("Ingrese el nuevo producto ");
                Productos[posicion] = Console.ReadLine();

                Console.WriteLine("Producto actualizado.");
            }
            else
            {
                Console.WriteLine("El producto no existe.");
            }

            break;

        case 5:
            Console.Write("Ingrese el nombre que desea eliminar: ");
            string eliminar = Console.ReadLine();

            if (Productos.Contains(eliminar))
            {
                Productos.Remove(eliminar);
                Console.WriteLine("El producto se elimino correctamente");
            }
            else
            {
                Console.WriteLine("El producto no existe...");
            }
        break;

        case 6:

            Console.WriteLine($"Total de productos: {Productos.Count}");
            break;

        case 7:

            Console.WriteLine("Saliendo....");
            break;

        default:

            Console.WriteLine("Opción no válida.");
            break;

    }

    if (opcion != 7)
    {
        Console.WriteLine("Presione una tecla...");
        Console.ReadKey();
    }

} while (opcion!=7);
