namespace Polomorfizam_i_Staticki_Klasi.Models
{
    public class Dog: Pet
    {
        public bool IsGoodBoi { get; set; }
        public override void Eat()
        {
            Console.WriteLine("The DAWG is eating ... NOMNOMNOM");
        }
    }
}
