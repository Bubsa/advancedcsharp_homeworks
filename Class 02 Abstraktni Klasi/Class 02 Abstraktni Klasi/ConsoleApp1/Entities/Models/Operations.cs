using ConsoleApp1.Entities.BaseEntity;

namespace ConsoleApp1.Entities.Models
{
    public class Operations : Human, IOperations
    {
        public List<string> Projects { get; set; } = new List<string>();
        public Operations(int id, string firstName, string lastName, int age, string phone, List<string> projects) : base(id, firstName, lastName, age, phone)
        {
            Projects = projects;
        }
    }
}
