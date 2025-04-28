using ConsoleApp1.Entities.Interfaces;

namespace ConsoleApp1.Entities.BaseEntity
{
    public abstract class Human : IHuman
    {
        public Human(int id, string firstName, string lastName, int age, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Phone = phone;
        }
        public Human()
        {
            
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; }

        // BARELY USED public abstract string Test { get; set; }


        public abstract string GetInfo();

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void Greet(string name)
        {
            Console.WriteLine($"Hey there ${name}. My name is {GetFullName()}");
        }

  
    }
}
