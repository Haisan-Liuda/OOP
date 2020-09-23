using System;
using System.Collections.Generic;

namespace problem_2
{
    class Program
    {
        class Person
        {
            private string Name;
            private int Age;
            public string name
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
            public int age
            {
                get
                {
                    return Age;
                }
                set
                {
                    Age = value;
                }
            }

            public Person()
            {
                Name = "No name";
                Age = 1;
            }

            public Person(int Age)
            {
                Name = "No name";
                this.Age = Age;
            }

            public Person(string Name, int Age)
            {
                this.Name = Name;
                this.Age = Age;
            }
        }
       

        static void Main(string[] args)
        {
            Console.WriteLine("input number:");
            int x = int.Parse(Console.ReadLine());
            List<Person> Persona = new List<Person>();
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("input name and age:");
                string[] input = Console.ReadLine().Split(' ');
                Persona.Add(new Person(input[0], int.Parse(input[1])));
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = i + 1; j < x; j++)
                {
                    if (string.Compare(Persona[i].name, Persona[j].name) > 0)
                    {
                        Person tmp = Persona[i];
                        Persona[i] = Persona[j];
                        Persona[j] = tmp;
                    }
                }
            }

            foreach (var person in Persona)
            {
                if (person.age > 30)
                {
                    Console.WriteLine($"{person.name} - {person.age}");
                }
            }

            Console.ReadKey();
        }
    }
}
