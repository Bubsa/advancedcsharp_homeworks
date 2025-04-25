using Task01.Logic.Models;

namespace Task01.Logic.Services
{
    public class TextService
    {
        public List<NameCountResult> CountAppearancesInText(string text, List<string> names) 
        {
            string[] wordsInText = text.Split(' ');

            List<NameCountResult> namesCountResult = new List<NameCountResult>();

            foreach (string name in names)
            {
                int nameCounter = 0;
                foreach (string word in wordsInText) 
                {
                    if (word.ToLower() == name.ToLower())
                    {
                        nameCounter++;
                    }
                }
                NameCountResult nameCountResult = new NameCountResult(name, nameCounter);
            }
            return namesCountResult;
        }
    }
}
