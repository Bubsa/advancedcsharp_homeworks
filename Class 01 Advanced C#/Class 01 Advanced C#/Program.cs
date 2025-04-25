using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using Task01.Logic.Services;

namespace Class_01_Advanced_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sho e C# - Objektno orienten jazik i eden od osnovnite jazici
            // DotNet - Environment kade sho moze da se napravat malce po kompleksni programi. 
            // DotNet Core & DoTNet FUll Framework. Ednoto e cross platform, full framework se postari verzii na framework sho bile koristeni samo za Microsoft
            // Klasi se tehnicki nacrt na kukja, objekt e realizacija na taa kukja.
            // Console App e aplikacija sho se izvrshuva vo konzola
            // Class library e biblioteka od klasi sho se logicko svrzani
            // EDNA OD ZADACHI SHO DAVAAT NA INTERVJUA E MANIPULACIJA SO STRINGOVI

            /*  The application should ask for names to be entered until the user enters 'x'. After that, the application should ask for a text.
  When that is done, the application should show how many times each name was included in the text(ignoring case).
              */

            TextService textService = new TextService();
            List<string> names = new List<string>() { "John", "Anna", "mark", "LisA"};

            string text = @"

     Once upon a time in a small village, there lived a man named John. John was known for his kindness and generosity.
     His neighbor, Anna, often came by to borrow sugar or just chat. One day, John and Anna decided to organize a small community event.
     They invited their friends Mark and Lisa to help with the arrangements. Lisa baked cookies while Mark handled the music.
     During the event, everyone praised John and Anna for their efforts. Later that evening, John wrote a thank-you note to Lisa and Mark.
     The next day, Mark visited John again, and they talked about how successful the event was.
     Even Anna stopped by with a basket of fruit as a thank-you gift. Everyone agreed that it was a day to remember, thanks to John, Anna, Mark, and Lisa."
            ;

            var result = textService.CountAppearancesInText(text, names);

            foreach (var item in result)
            {
                Console.WriteLine($"Name: {item.Name}. Count: {item.Count}");
            }

        }
    }
}
