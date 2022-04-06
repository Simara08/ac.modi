using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionn11
{
    class Library
    {
        public int BookLimit;
        public Library(int booklimit)
        {
            BookLimit = booklimit;
        }
        Book[] books = new Book[0];
        public void AddBook(Book book )
        {
            if (books.Length<BookLimit)
            {
                books[books.Length] = book;
                Array.Resize(ref books, books.Length + 1);
            }
            
        }

        internal void GetBook()
        {
            throw new NotImplementedException();
        }

        public void GetBook(int? BookId)
    {
        if (!(BookId is null))
        {
            if (!(books[(int)BookId - 1] is null))
            {
                if (!(books[(int)BookId - 1].IsAvailable))
                {
                    Console.WriteLine("Books is avaible");
                }
            }
        }

    }
}
}
