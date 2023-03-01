using System;
namespace immutablePractice
{
    class Program
    {
        class Student
        {
            // auto-implemented properties
            public int Id { get; init; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // default constructor
            public Student()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
            }
            // parameterized constructor
            public Student(int i)
            {
                Id = i;
                FirstName = string.Empty;
                LastName = string.Empty;
            }
            public Student(int i, string First, string Last)
            {
                Id = i;
                FirstName = First;
                LastName = Last;
            }
        }

        public static void Main(string[] args)
        {
            Student student1 = new Student(4, "Ted", "Fisher");
            Student student2 = new Student(6);
            student2.FirstName = "Jared";
            student2.LastName = "Lamberg";

            Console.WriteLine($"First Student -\nID: {student1.Id}\nFirst Name: {student1.FirstName}\nLast Name: {student1.LastName}\n");
            Console.WriteLine($"First Student -\nID: {student2.Id}\nFirst Name: {student2.FirstName}\nLast Name: {student2.LastName}");
        }
    }
}