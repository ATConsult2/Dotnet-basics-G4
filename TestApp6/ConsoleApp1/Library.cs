using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    public delegate void NewBookHandler(string message);
    
    [LogLevel]
    internal class Library
    {
        public event NewBookHandler NewBook;
        public List<Book> Books { get; set; }

        public Library(List<Book> books)
        {
            Books = books;
        }

        public bool AddBook(Book book)
        {
            Books.Add(book);
            NewBook?.Invoke($"New Book \"{book.Title}\" in Catalogue! Hurry UP! ");
            return true;
        }
    }
}
