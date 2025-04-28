using ConsoleApp1.Entities.BaseEntity;
using ConsoleApp1.Entities.Interfaces;

namespace ConsoleApp1.Entities.Models
{
    public class QAEngineer : Human, ITester, IDeveloper
    {
        public List<string>TestingFrameworks { get; set; }
        public QAEngineer(int id, string firstName, string lastName, int age, string phone, List<string>testingFrameworks) : base(id, firstName, lastName, age, phone)
        {
            TestingFrameworks = testingFrameworks;
        }

        public override string GetInfo()
        {
            return $"{GetFullName()} ({Age}) - Knows testing frameworks {string.Join(",", TestingFrameworks)}";
        }

        public void TestFeature(string feature)
        {
            Console.WriteLine("Run unit tests");
            Console.WriteLine("Run Automated tests...");
            Console.WriteLine($"Tests for the {feature} feature are completed");
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak....");
            Console.WriteLine("Write Automation tests ...");
            Console.WriteLine("tak tak tak....");
        }
    }
}
