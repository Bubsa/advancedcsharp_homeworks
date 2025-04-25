namespace Task01.Logic.Models
{
    public class NameCountResult
    {
        public int Count { get; set; }
        public string Name { get; set; }

        public NameCountResult(string name,int count)
        {
            Name = name;
            Count = count;
        }
    }
   
}
