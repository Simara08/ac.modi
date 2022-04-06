using System;

namespace Exceptionn11
{
    class Program
    {
        static void Main(string[] args)
        {
            Book kitab = new Book("Qaraqan",10,1,"qaraqan",200);
            Library kitabxana = new Library(1);
            kitabxana.AddBook(kitab);
            kitab.ShowInfo();
            kitabxana.GetBook();
        }
    }
}
