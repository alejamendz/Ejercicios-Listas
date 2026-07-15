List<string> cursos=new List<string>();
int opcion;

do
{
    Console.Clear();

    Console.WriteLine("GESTION DE CURSOS");
    Console.WriteLine("1. Registrar un curso ");
    Console.WriteLine("2. Mostrar todos los cursos registrados");
    Console.WriteLine("3. Buscar un curso por su nombre.");
    Console.WriteLine("4. Cambiar el nombre de un curso.");
    Console.WriteLine("5. Eliminar un curso. ");
    Console.WriteLine("6. Mostrar el total de cursos registrados.");
    Console.WriteLine("7. Salir");

    Console.WriteLine("Ingrese una opcion: ");
    opcion = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    switch (opcion)
    {

        case 1:
            Console.WriteLine("Ingrese el curso: ");
            string curso=Console.ReadLine();
            cursos.Add(curso);

            Console.WriteLine("¡Se agrego el curso!");
            break;

        case 2:
            Console.WriteLine("Cursos registrados: ");
            if(cursos.Count==0)
            {
                Console.WriteLine("No hay cursos registrados");
            }
            else
            {
                int contador = 1;
                foreach(string cursoT in cursos)
                {
                    Console.WriteLine($"{contador}. {cursoT}");
                    contador++;
                }
            }
            break;

        case 3:
            Console.WriteLine("Ingrese el nombre del curso a buscar: ");
            string buscar= Console.ReadLine();

            if (cursos.Contains(buscar))
            {
                Console.WriteLine("El curso si existe");
                Console.WriteLine($"Posicion: {cursos.IndexOf(buscar)}");
            }
            else
            {
                Console.WriteLine("El curso no existe... ");
            }

        break;

        case 4:
            Console.WriteLine("Ingrese el curso que desea cambiar: ");
            string cambiar= Console.ReadLine();

            if(cursos.Contains(cambiar))
            {
                int posicion = cursos.IndexOf(cambiar);
                Console.WriteLine("Ingrese el nuevo curso: ");
                cursos[posicion] = Console.ReadLine();

                Console.WriteLine("Curso registrado.");
            }
            else
            {
                Console.WriteLine("El producto no existe.");
            }
        break;
        
        case 5:
            Console.WriteLine("Ingrese el curso que desea eliminar: ");
            string eliminar= Console.ReadLine();

            if(cursos.Contains(eliminar))
            {
                cursos.Remove(eliminar);
                Console.WriteLine("Se elimino el curso...");
            }
            else
            {
                Console.WriteLine("No existe ese curso...");
            }

        break;

        case 6:
            Console.WriteLine($"Total de cursos registrados: {cursos.Count}");

        break;

        case 7:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;

    }

    if (opcion != 7)
    {
        Console.WriteLine("Presione una tecla...");
        Console.ReadKey();
    }
} while (opcion != 7);