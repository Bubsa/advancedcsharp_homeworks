namespace Generichki_i_Ekstenzivni_Metodi.Helpers
{
    public class GenericListHelper
    {

        public void PrintList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintInfo<T>(List<T> list)
        {
            foreach (T item in list)
            {
                T first = list.First();
                Console.WriteLine($"This list has {list.Count} elements and is of type {first.GetType().Name}!");
            }
        }
    }
}
