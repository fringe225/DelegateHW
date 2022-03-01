using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW.Models
{
    internal class Book
    {
        private static int _count = 1;
        public string Code { get;}

        public string Name { get; set; }

        public string AuthorName { get; set; }
        public int PageCount { get; set; }


        public Book(string name, string authorName, int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = $"{name[0..2].ToUpper()}{_count}";
            _count++;
        }

        public override string ToString()
        {
            return $"Book Code: {Code}\n" +
                   $"Name: {Name}\n" +
                   $"Author Name: {AuthorName}\n" +
                   $"Page Count: {PageCount}\n";

        }
    }
}
