namespace Polomorfizam_i_Staticki_Klasi.Models
{
    public class Cat: Pet
    {
        public bool IsLazy { get; set; } = true;
        public override void Eat()
        {
            Console.WriteLine("The cate is eating dayme");
        }
    }
}
