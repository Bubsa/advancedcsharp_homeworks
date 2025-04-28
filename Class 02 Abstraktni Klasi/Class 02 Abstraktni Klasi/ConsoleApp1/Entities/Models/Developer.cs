using ConsoleApp1.Entities.BaseEntity;
using ConsoleApp1.Entities.Interfaces;

namespace ConsoleApp1.Entities.Models
{
    public class Developer : Human, IDeveloper
    {
        public Developer(int id, string firstName, string lastName, int age, string phone, List<string> programmingLanguages, int featuresDeveloped) : base(id, firstName, lastName, age, phone)
        {
            //Id = id;
            //FirstName = firstName;
            //LastName = lastName;
            //Age = age;
            //Phone = phone;
            ProgrammingLanguages = programmingLanguages;
            FeaturesDeveloped = featuresDeveloped;
        }

        //public int Id { get; set; }
        //public string FirstName { get; set; } = string.Empty;
        //public string LastName { get; set; } = string.Empty;
        //public int Age { get; set; }
        //public string Phone { get; set; } = string.Empty;
        public List<string> ProgrammingLanguages { get; set; } = new List<string>();
        public int FeaturesDeveloped { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public override string GetInfo()
        {
            Console.WriteLine("dasdsad");
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak ....");
            Console.WriteLine("Opens ChatGPT ....");
            Console.WriteLine("tak tak tak tak tak ....");
        }


    }
}
