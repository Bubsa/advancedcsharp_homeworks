namespace Polomorfizam_i_Staticki_Klasi.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public virtual void Eat()
        {
            Console.WriteLine("Nom nom nom");
        }
    }
}
