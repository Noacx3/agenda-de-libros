using agenda_de_libros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_de_libros
{

    //solo cree esta clase para limpiar la clase Program
    class menu {
       public static void Menu()
        {
            Catalogo catalogo = new Catalogo();

            while (true)
            {
                MostrarMenu();

                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarLibro(catalogo);
                        break;
                    case "2":
                        catalogo.MostrarCatalogo();
                        break;
                    case "3":
                        BuscarLibro(catalogo);
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
        }

         static void MostrarMenu()
        {
            Console.WriteLine("==== Catálogo de Libros ====");
            Console.WriteLine("1. Agregar Libro");
            Console.WriteLine("2. Mostrar Catálogo");
            Console.WriteLine("3. Buscar Libro por Título");
            Console.WriteLine("4. Salir");
        }

        static void AgregarLibro(Catalogo catalogo)
        {
            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();

            Console.Write("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();

            Console.Write("Ingrese el año de publicación del libro: ");
            int anioPublicacion = int.Parse(Console.ReadLine());

            catalogo.AgregarLibro(titulo, autor, anioPublicacion);

            Console.WriteLine("presione cualquier letra para volver al menu");
            Console.ReadKey();
            Console.Clear();
        }

        static void BuscarLibro(Catalogo catalogo)
        {
            Console.Write("Ingrese el título del libro a buscar: ");
            string tituloBuscar = Console.ReadLine();
            catalogo.BuscarLibro(tituloBuscar);

            Console.WriteLine("presione cualquier letra para volver al menu");
            Console.ReadKey();
            Console.Clear();
        }
    }

}