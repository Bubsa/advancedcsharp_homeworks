namespace Statichki_Klasi.Entities.Helpers
{
    public static class ConsoleHelper
    {
        public static void WriteInColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        // OVA OBICHNA METODA BO STATICHNA KLASA NE RABOTI. MORA DA BIDE STATICHNA I TAA
        //public void PrintSomething()
        //{
        //    Console.WriteLine("Something");
        //}
    }
}
