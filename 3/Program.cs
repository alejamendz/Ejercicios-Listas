using System.Diagnostics;

List<string> ciudadesT = new List<string>();

int opcion;

do
{
    Console.WriteLine("GESTIÓN DE CIUDADES");
    Console.WriteLine("1. Agregar una ciudad");
    Console.WriteLine("2. Mostrar todas las ciudades registradas");
    Console.WriteLine("3. Buscar ciudad");
    Console.WriteLine("4. Modificar el nombre de una ciudad");
    Console.WriteLine("5. Eliminar una ciudad");
    Console.WriteLine("6. Mostrar la cantidad de ciudades");
    Console.WriteLine("7. Salir del programa");


    Console.WriteLine("Ingrese opcion: ");
    opcion=Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    switch(opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el nombre de la ciudad: ");
            string nombre=Console.ReadLine();
            ciudadesT.Add(nombre);

            Console.WriteLine("¡Se agrego la ciudad!");
            break;
        case 2:
            Console.WriteLine("LISTADO DE CIUDADES");
            if(ciudadesT.Count==0)
            {
                Console.WriteLine("No existen ciudades...");
            }
            else
            {
                int contador = 1;
                foreach(string ciudad in ciudadesT)
                {
                    Console.WriteLine($"{contador}.{ciudad}");
                    contador++;
                }
            }
            break;
        case 3:

            Console.WriteLine("Ingrese el nombre de la ciduad a buscar");
            string buscar=Console.ReadLine();   

            if(ciudadesT.Contains(buscar))
            {
                Console.WriteLine("La ciudad si existe");
                Console.WriteLine($"Posicion: {ciudadesT.IndexOf(buscar)}");
            }
            else
            {
                Console.WriteLine("No existe la ciudad");
            }
            break;
        case 4:
            Console.WriteLine("Ingrese le nombre de la ciudad a modificar");
            string modificar=Console.ReadLine();
            
            if(ciudadesT.Contains(modificar))
            {
                int posicion = ciudadesT.IndexOf(modificar);
                Console.WriteLine("Ingrese la nueva ciudad: ");
                ciudadesT[posicion] = Console.ReadLine();

                Console.WriteLine("¡Ciudad registrada!");
            }
            else 
            {
                Console.WriteLine("No existe la ciudad...");

            }
            break;
        case 5:
            Console.WriteLine("Ingrese ciudad a eliminar: ");
            string eliminar= Console.ReadLine();

            if(ciudadesT.Contains(eliminar))
            {
                ciudadesT.Remove(eliminar); 
                Console.WriteLine("Se elimino la ciudad...");
            }
            else
            {
                Console.WriteLine("No existe la ciudad...");
            }
        break;

        case 6:
            Console.WriteLine($"El total de ciudades es: {ciudadesT.Count}");
            break;

        case 7:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opcion no valida...");
            break;
    }
    if(opcion!=7)
    {
        Console.WriteLine("Presione cualquier tecla...");
        Console.ReadKey();
    }

} while (opcion != 7);