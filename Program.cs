namespace parallel_arrays
{
    internal class Program
    {
        static string[] Inventoryprinter(int[] array1, string[] array2)
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
            string[] names = new string[2] { "pear", "apple"};
            int[] quantity = new int[2] { 5 ,10 };
            Console.WriteLine("Inventory List:");
            Console.WriteLine(Inventoryprinter(quantity, names));    


        }
        }
    }
}


