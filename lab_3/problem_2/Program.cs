using System;


namespace problem_2
{
    class Program
    {
        class Person
        {
            private string Name ;
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
        class Family
        {
            private List<Person> FamilyMembers;

            public Family()
            {
                FamilyMembers = new List<Person>();
            }

            public void AddMember(Person Member)
            {
                FamilyMembers.Add(Member);
            }

            public Person GetOldestMember()
            {
                int maxAge = FamilyMembers[0].Age;
                Person Oldest = FamilyMembers[0];
                foreach (var Member in FamilyMembers)
                {
                    if (Member.age > maxAge)
                    {
                        maxAge = Member.age;
                        Oldest = Member;
                    }
                }
                return Oldest;
            }
        }

        static void Main(string[] args)
        {
            var person = new Person(20);
            Console.WriteLine($"{nameof(person)}: {person.name}, age: {person.age}");

            Console.ReadKey();
        }
    }
}