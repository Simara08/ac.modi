using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionn11
{
  abstract  class Product
    {
        private static int id;
        public int Id { get;  }
        public Product()
        {
            Id = id++;
        }
        private static string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != "" || name != " ")
                {
                    name = value;
                }
                Console.WriteLine("Ad daxil edin");
            }
        }

        private static double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price != 0)
                {
                    price = value;
                }
                Console.WriteLine("Price daxil edin");
            }
        }  private static double count;
        public double Count;
        
        public double TotalInCome;
        public abstract void ShowInfo();
        public abstract void Sell();

         
        
    }
}
