namespace Generichki_i_Ekstenzivni_Metodi.Helpers
{
    public class NotGenericListHelper
    {
        public void PrintStrings(List<string> strings)
        {
            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintInfoForStrings(List<string> strings) 
        {
            string first = strings.First();
            Console.WriteLine($"This list has {strings.Count} elements and is of type {first.GetType().Name}!");
        }

        public void PrintInt(List<int> integers)
        {
            foreach (int item in integers)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintBooleans(List<bool> bools)
            {
                foreach (bool item in bools)
                {
                    Console.WriteLine(item);
                }
            }

        public void PrintForIntegers(List<int> integers)
        {
            int first = integers.First();
            Console.WriteLine($"This ");
        }
        }
    }

