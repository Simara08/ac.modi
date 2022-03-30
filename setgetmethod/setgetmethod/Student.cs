using System;
using System.Collections.Generic;
using System.Text;

namespace setgetmethod
{
    class Student
    {
        public Student(int v)
        {

        }
        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string Surname
        {
            get
            {
                return Surname;
            }
            set
            {
                Surname = value;
            }
        }
        public string Speciality
        {
            get
            {
                return Speciality;
            }
            set
            {
                Speciality = value;
            }
        }
    }
}
