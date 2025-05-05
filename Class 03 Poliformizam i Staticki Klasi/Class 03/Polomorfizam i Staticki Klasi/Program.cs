// See https://aka.ms/new-console-template for more information
using Polomorfizam_i_Staticki_Klasi;
using Polomorfizam_i_Staticki_Klasi.Models;

Console.WriteLine("Hello, World!");

#region Runtime Polymorphism
Dog dzeki = new Dog
{
    Name = "Dzeki",
    IsGoodBoi = true
};
dzeki.Eat();

Cat zuza = new Cat
{
    Name = "Zuza",
    IsLazy = true
};

zuza.Eat();
#endregion

#region Compile-Time Polimorfizam
PetService petService = new PetService();

petService.PrintPetInfo(dzeki);
petService.PrintPetInfo();
petService.PrintPetInfo(dzeki, "Dzoni");
petService.PrintPetInfo("Dzoni", dzeki);
#endregion