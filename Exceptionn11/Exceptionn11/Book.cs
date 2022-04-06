using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionn11
{
    class Book:Product
    {
        public static string authorname;
        public string AuthorName
        {
            get
            {
                return authorname;
            }
            set
            {
                if (authorname != "" || authorname != " ")
                {
                    authorname = value;
                }
                Console.WriteLine("Authorname daxil edin");
            }
        }
        public static int pagecount;
        public int PageCount
        {
            get
            {
                return pagecount;
            }
            set
            {
                if (pagecount != 0)
                {
                    pagecount = value;
                }
                Console.WriteLine("Authorname daxil edin");
            }
        }

        public bool IsAvailable { get; internal set; }

        public Book(string name,double price,int count,string authorname, int pagecount)
        {
            Name = name;
            Price = price;
            Count = count;
            AuthorName = authorname;
            PageCount = pagecount;
        }

        public override void Sell()
        {
            TotalInCome += Price;
            Count--;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name-{Name} Price-{Price} Authorname-{AuthorName}");
        }
    }
}
