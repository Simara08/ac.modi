using System;
using System.Collections.Generic;
using System.Text;

namespace enummmm
{
    class Square:Fiqure
    {
        private int _side;
        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value > 0)
                {
                    _side = value;
                }
                else
                {
                    Console.WriteLine("Duzgun eded daxil edin");
                }
            }
        }

        public override void Calcarea()
        {
            Console.WriteLine($"Square area {Side*Side}");
        }
    }
}
