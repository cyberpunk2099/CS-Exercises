using System;

namespace MaximumSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Subarray Problem");
            Console.WriteLine("Sample Array: 1, -3, 2, 1, -1");
            Console.WriteLine("Quit: q");
            while (true)
            {
                Console.Write("Array: ");
                var array = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(array)) continue;
                if (array.ToLowerInvariant() == "q") return;
                var subarray = "";
                try
                {
                    subarray = Calc.GetMaximumSubarray(array);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"ERROR: {e.Message}\r\n");
                    continue;
                }
                Console.WriteLine($"Maximum Subarray: {subarray}\r\n");
            }
        }
    }
}
