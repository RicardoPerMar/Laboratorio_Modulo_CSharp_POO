using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Modulo_CSharp_POO
{

    class Program
    {

        public static bool IsBookRead(List<Book> book, string titleToSearch)
        {
            bool check = false;
            for (int i = 0; i < book.Count; i++)
            {
                if (string.Equals(book[i].title, titleToSearch)) // Con este condicional se controla si existe o no existe
                {
                    if (book[i].isRead)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }

        static void Main(string[] args)
        {
            List<Book> books = new List<Book>() { // En lugar de utilizar un Array he utilizado un ArrayList por si ha de añadirse mas libros
                new Book("El imperio final", true),
                new Book("Palabras Radiantes", true),
                new Book("El ritmo de la guerra", false)
            };

            Console.WriteLine(IsBookRead(books, "Palabras Radiantes"));
            Console.WriteLine(IsBookRead(books, "El imperio final"));
            Console.WriteLine(IsBookRead(books, "Juramentada"));
        }
    }
}
