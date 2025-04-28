using ConsoleApp1.Entities.BaseEntity;
using ConsoleApp1.Entities.Interfaces;

namespace ConsoleApp1.Entities.Models
{
    public class Tester : Human, ITester
    {
        public int BugsFound { get; set; }
        public Tester(int id, string firstName, string lastName, int age, string phone, int bugsFound) : base(id, firstName, lastName, age, phone)
        {
            BugsFound = bugsFound;
        }

        public override string GetInfo()
        {
            return $"{GetFullName()} ({Age}) - found {BugsFound} bugs so far}";
        }

        public void TestFeature(string feature)
        {
            Console.WriteLine($"{feature} is being tested...");
            Console.WriteLine("Testing completed");
        }
    }
}
