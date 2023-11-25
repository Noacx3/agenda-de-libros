using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_de_libros
{
       public  class Libro
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public int AnioPublicacion { get; set; }

            public Libro(string titulo, string autor, int anioPublicacion)
            {
                Titulo = titulo;
                Autor = autor;
                AnioPublicacion = anioPublicacion;
            }

            public void MostrarInformacion()
            {
                Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Año de Publicación: {AnioPublicacion}");
            }
        }
    }
