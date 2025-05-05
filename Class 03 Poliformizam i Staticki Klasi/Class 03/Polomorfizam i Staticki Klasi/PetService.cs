using Polomorfizam_i_Staticki_Klasi.Models;

namespace Polomorfizam_i_Staticki_Klasi
{
    public class PetService
    {
        public void PrintPetInfo()
        {
            Console.WriteLine("Print some info");
        }

        public void PrintPetInfo(Dog doggy)
        {
            Console.WriteLine($"Dog {doggy.Name} is {(doggy.IsGoodBoi ? "good boi" : "NOT good boi")}");
        }
        public void PrintPetInfo(Dog doggy, string owner) // istata metoda ko gore samo so dodaden eden parametar aka owner
        {
            Console.WriteLine($"Dog {doggy.Name} is {(doggy.IsGoodBoi ? "good boi" : "NOT good boi")}. Owner: {owner}");
        }
        public void PrintPetInfo(string owner, Dog doggy) // istata funkcija ko gore samo smenet redosledot na parametrite
        {
            Console.WriteLine($"Dog {doggy.Name} is {(doggy.IsGoodBoi ? "good boi" : "NOT good boi")}. Owner: {owner}");
        }
    }
}
