using System;
using System.Collections.Generic;
using System.Text;

namespace exceptionnn
{
    class Hotel
    {
        public static string Name;
        Room[] Rooms = new Room[0];
        public void AddRoom(Room room)
        {
            Rooms[Rooms.Length] = room;
            Array.Resize(ref Rooms, Rooms.Length + 1);
        }
        public void MakeReservation(int? roomid)
        {
            if (!(roomid is null))
            {
                if (!(Rooms[(int)roomid - 1] is null))
                {
                    if (!(Rooms[(int)roomid - 1].IsAvailable))
                    {
                        Console.WriteLine("Rooms is avaible");
                    }
                }
            }
          
        }
        public Room this[int index]
        {
            get
            {
                if (index > Rooms.Length - 1)
                {
                    throw new OutOfCapasityException("This index is not exist");
                }
                else if (Rooms[index] == null)
                {
                    throw new EmptyBookException("This index is not set");
                }
                return Rooms[index];

            }
            set
            {
                if (index <= Rooms.Length - 1 && Rooms[index] == null)
                {
                    Rooms[index] = value;
                }
            }
        }

    }
}
