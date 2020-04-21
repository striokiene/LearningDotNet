using System;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zodziai = new string[5] {"labas", "sudie", "aciu", "myliu", "Lietuva"};
            for (int i = 0; i < zodziai.Length; i++)
            {
                Console.WriteLine(zodziai[i]);
            }
            int[] skaiciai = new int[20] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
            Array.Reverse(skaiciai);
            foreach (int i in skaiciai)
            {
                Console.WriteLine(i);
            }
        }

    }
}