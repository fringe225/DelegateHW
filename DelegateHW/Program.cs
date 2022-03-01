using System;
using DelegateHW.Models;
namespace DelegateHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook("Programing Basics", "Tural", 250);
            library.AddBook("Economy", "Vusal", 1250);
            library.AddBook("War And Peace", "Onur", 750);
            library.AddBook("Dumsuy", "Ismayil", 950);
            library.AddBook("Reasons to by Happy", "Seid", 650);
            library.AddBook("How to .NET", "Togrul", 450);

            library.ShowBooks();

            //PrintBooks(library.FindAllBooksByName("to"));
            //PrintBooks(library.FindAllBooksByPageCountRange(400,1000));
            library.RemoveAllBookByName("to");
            Console.WriteLine("----------------------------");
            library.ShowBooks();



        }

        static void PrintBooks(List<Book> lstBooks)
        {
            foreach (var lstBook in lstBooks)
            {
                Console.WriteLine("----------------------------------");
                Console.Write(lstBook);
                Console.WriteLine("----------------------------------");

            }
        }
    }
}

