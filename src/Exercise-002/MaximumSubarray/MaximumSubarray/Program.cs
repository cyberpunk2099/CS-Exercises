using System;

namespace MaximumSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MAXIMUM SUBARRAY PROBLEM");
            Console.WriteLine("Sample Array: 1, -3, 2, 1, -1");
            Console.WriteLine("Quit: q");
            while (true)
            {
                Console.Write("Array: ");
                var array = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(array)) continue;
                if (array.ToLowerInvariant() == "q") return;
                try
                {
                    Console.Write($"Maximum Subarray: {Helper.GetMaximumSubarray(array)}\r\n\r\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"ERROR: {e.Message}\r\n");
                }
            }
        }
    }
}
