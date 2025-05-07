namespace Ekstenzii.Helpers
{
    public static class StringExtensions
    {
        public static string Shorten(this string text, int numberOfWords)
        {
            string[] words = text.Split(' ');
            string result = string.Empty;
            for (int i = 0; i < numberOfWords; i++) 
            {
                result += words[i] + " ";
            }
            return result;

        }

        //Ova e metoda za dodavanje navodnici na text
        public static string QuoteString(this string text)
        {
            return $"\"{text}\"";
        }

        public static string  ToNumberString (this int number)
        {
            return $"The number is {number}";
        }

    }
}
