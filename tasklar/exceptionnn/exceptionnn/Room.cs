using System;
using System.Collections.Generic;
using System.Text;

namespace exceptionnn
{
    class Room
    {
        private static int id = 0;
        readonly  int Id;
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
                if (price !=0)
                {
                    price = value;
                }
                Console.WriteLine("Price daxil edin");
            }
        }
        private static int personcapacity;
        public int PersonCapacity
        {
            get
            {
                return personcapacity;
            }
            set
            {
                if (price != 0)
                {
                    personcapacity = value;
                }
                Console.WriteLine("PersonCapacity daxil edin");
            }
        }
        public bool IsAvailable=true;

        public override string ToString()
        {
            return ShowInfo();
        }

        public string ShowInfo()
        {
            return $"ID-{Id} Name-{Name} Price{Price} PersonCapacity{PersonCapacity} IsAvailable-{IsAvailable}";
        }
        public Room()
        {
            Id = id++;
        }
    }
}
