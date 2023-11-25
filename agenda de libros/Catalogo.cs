using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_de_libros
{
    internal class Catalogo
    {
        private List<Libro> libros;

        public Catalogo()
        {
            libros = new List<Libro>();
        }

        public void AgregarLibro(string titulo, string autor, int anioPublicacion)
        {
            Libro nuevoLibro = new Libro(titulo, autor, anioPublicacion);
            libros.Add(nuevoLibro);
            Console.WriteLine("Libro agregado con éxito.\n");
            Console.WriteLine("presione cualquier letra para volver al menu");
            Console.ReadKey();
            Console.Clear();

        }

        public void MostrarCatalogo()
        {

            Console.WriteLine("==== Catálogo de Libros ====");
            foreach (var libro in libros)
            {
                libro.MostrarInformacion();
            }
            Console.WriteLine();
            Console.WriteLine("presione cualquier letra para volver al menu");
            Console.ReadKey();
            Console.Clear();
        }

        public void BuscarLibro(string tituloBuscar)
        {
            Console.Clear();
            var librosEncontrados = libros.FindAll(libro => libro.Titulo.Contains(tituloBuscar));

            if (librosEncontrados.Count > 0)
            {
                Console.WriteLine("Libros encontrados:");
                foreach (var libro in librosEncontrados)
                {
                    libro.MostrarInformacion();
                }
            }
            else
            {
                Console.WriteLine("No se encontraron libros con ese título.");
            }

            Console.WriteLine();
            Console.WriteLine("presione cualquier letra para volver al menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
