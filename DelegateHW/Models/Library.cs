using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW.Models
{
    internal class Library
    {
        private List<Book> _books;
        public List<Book> Books => _books;


        public Library()
        {
            _books=new List<Book>();
        }

        public void AddBook(string name, string authorName, int pageCount)
        {
            Book book = new Book(name,authorName,pageCount);

            _books.Add(book);
        }

        public void ShowBooks()
        {
            foreach (var book in _books)
            {
                Console.WriteLine(book);
            }
        }
        public List<Book> FindAllBooksByName(string search)
        {
            List<Book> result = new List<Book>();

            foreach (var book in _books)
            {
                if (book.Name.Contains(search))
                {
                    result.Add(book);
                }
            }

            return result;
        }

        public void RemoveAllBookByName(string search)
        {
            
            List<Book> newBooks = new List<Book>();

            foreach (var book in _books)
            {
                if (book.Name.ToLower().Contains(search))
                {
                    newBooks.Add(book);
                }
            }

            foreach (var newBook in newBooks)
            {
                _books.Remove(newBook);
            }


        }

        public List<Book> SearchBooks(string search)
        {
            List<Book> result = new List<Book>();

            foreach (var book in _books)
            {
                if (book.Name.Contains(search) || book.AuthorName.Contains(search) || book.PageCount.ToString().Contains(search))
                {
                    result.Add(book);
                }
            }

            return result;
        }

        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            List<Book> result = new List<Book>();

            foreach (var book in _books)
            {
                if (book.PageCount>min && book.PageCount<max)
                {
                    result.Add(book);
                }
            }

            return result;
        }

        public void RemoveByNo(string search)
        {
            Book tempBook = null;

            foreach (var book in _books)
            {
                if (book.Code.ToLower().Contains(search))
                {
                    tempBook = book;
                }
            }

            _books.Remove(tempBook);

        }


    }
}
