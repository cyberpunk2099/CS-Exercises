using System;
using System.Linq;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            void print(string s) => Console.WriteLine(s);
Start:
            Console.WriteLine("\r\nSORT ALGORITHMS\r\n");
            while (true)
            {
                Console.Write("Count: ");
                if (!int.TryParse(Console.ReadLine(), out var count)) continue;
                if (count < 4)
                {
                    print("Too small to sort!");
                    continue;
                }
                try
                {
                    while (true)
                    {
                        var array = Utils.CreateRandomArray(count, 100, 1);
                        print(array.ToShortText());
                        print($"Sort {count} items with: ");
                        print(" (S)election Sort");
                        print(" (B)ubble Sort");
                        print(" I(n)sertion Sort");
                        print(" (M)erge Sort");
                        print("  -or-");
                        print(" (R)estart");
                        print(" E(X)IT");

                        var key = Console.ReadKey().KeyChar.ToString().ToUpper();
                        var start = Environment.TickCount;
                        switch (key)
                        {
                            case "S":
                                array.SelectionSort();
                                print($"\r\n{array.ToShortText()}");
                                print(
                                    $"\r\n{count} items are sorted by 'Selection Sort' " +
                                    $"({Environment.TickCount - start}ms) \r\n");
                                break;
                            case "B":
                                array.BubbleSort();
                                print($"\r\n{array.ToShortText()}");
                                print(
                                    $"\r\n{count} items are sorted by 'Bubble Sort' " +
                                    $"({Environment.TickCount - start}ms) \r\n");
                                break;
                            case "N":
                                var list = array.ToList();
                                list.InsertionSort();
                                print($"\r\n{list.ToShortText()}");
                                print(
                                    $"\r\n{count} items are sorted by 'Insertion Sort' " +
                                    $"({Environment.TickCount - start}ms) \r\n");
                                break;
                            case "M":
                                throw new NotImplementedException("M");
                            case "R":
                                goto Start; // :) 
                            case "X":
                                return;
                            default:
                                print("Select an algorithm");
                                continue;
                        }
                        print(" -press any key to continue- \r\n");
                        Console.ReadKey();
                    }
                }
                catch (Exception e)
                {
                    print($"\r\nERROR: {e.Message}  ({e.GetType().Name})\r\n");
                    goto Start;
                }
            }
        }
    }
}
