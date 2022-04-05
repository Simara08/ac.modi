using System;
using System.Collections.Generic;
using System.Text;

namespace enummmm
{
    class Rectangle:Fiqure
    {
        private int _length;
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    Console.WriteLine("Duzgun eded daxil edin");
                }
            }
        }
        private int _width;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value>0)
                {
                    _width = value;
                }
            }
        }

        public override void Calcarea()
        {
            Console.WriteLine($"Restagle area{Length*Width}");
        }
    }

}
