// See https://aka.ms/new-console-template for more information
using Ekstenzii.Helpers;
using Ekstenzii.Models;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

#region String Extensions

string text = "C# is an awesome subject with great demos and activities";
Console.WriteLine(text.ToLower());
Console.WriteLine(string.Join("JOIN", text.Split(' ')));
Console.WriteLine(text.Replace("awesome", "tapa"));

// Edna obichna verzija kako da napravis normalna metoda kaj sho pishuvas tekst i pishuvas od toj tekst kolku zborovi da ti se vratat

//string shortenString = StringExtensions.Shorten(text, 5);
//Console.WriteLine(shortenString);

// Verzija na Ekstenzija metoda
Console.WriteLine(text.Shorten(5));

// Ekstenzija na quoted string metoda
string quotedString = "This is a quoted string".QuoteString();
Console.WriteLine(quotedString);

// Ekstenzija na NumberString
Console.WriteLine(32.ToNumberString()); 

// Ekstenzija na PrintStrings
List<string> strings = new List<string>() { "str1", "str2", "str3"};
strings.PrintStrings();

// Ekstenzija i Generica
List<int> integers = new() { 3215, 54, 869, 558549 };
integers.Print();
#endregion


#region ProductExtensions and Models exercise

List<Product> products = new List<Product>()
{
    new () { Id = 1, Title = "Product 1", Description = "Description 1"},
    new () { Id = 2, Title = "Product 2", Description = "Description 2"},
    new () { Id = 3, Title = "Product 3", Description = "Description 3"},
};

products.Print();
Console.WriteLine("===========================\n\n");
products.PrintInfo();
#endregion