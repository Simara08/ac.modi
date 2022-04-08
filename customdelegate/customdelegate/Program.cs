using System;
using System.Collections.Generic;

namespace customdelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("elehber","Maharramli",21);
            Person person2 = new Person("Simara","Maharramli",20);
            Person person3 = new Person("Simara","Maharramli",20);
            Person person4 = new Person("Eli","Maharramli",21);
           

            List<Person> persons = new List<Person>();
            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            persons.Add(person4);
            //persons.Find(x => x.Age == 21);
            //Console.WriteLine(persons.Find(Person => Person.Age == 21).Name);
            //foreach (var item in persons.FindAll(Person => Person.Age == 21))
            //{
            //    Console.WriteLine(item.Name);
            //}
            Console.WriteLine(persons.FindLast(x => x.Age == 21).Name);
            Console.WriteLine(persons.Exists(x => x.Name == "bdhshbds"));

            persons.Sort((a,b)=>a.Age-b.Age);
            foreach (Person item in persons)
            {
                Console.WriteLine(item);
            }
        }


    }
}
