namespace parallel_arrays
{
    internal class Program
    {
        static string[]  Inventoryprinter(int[] array1, string[] array2)
        {
            string[] result = new string[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] + array2[i];
            }
            return result;
 
        }
        static void Main(string[] args)
        {
            string[] names = new string[5];
            int[] quantity = new int[5];
            string[] names = { "pear"; "sugar")
            int[] quantity = { 5; 10;}
        Console.WriteLine(Inventoryprinter(quantity, names));
    }
    }
}
