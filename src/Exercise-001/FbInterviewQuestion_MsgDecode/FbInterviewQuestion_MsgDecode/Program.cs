using System;

namespace FbInterviewQuestion_MsgDecode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facebook Coding Interview Question");
            Console.WriteLine(" How Many Ways to Decode This Message?");
            Console.WriteLine(" - Sample message: 85121215");
            Console.WriteLine(" - Quit: q \r\n");
            while (true)
            {
                Console.Write("Enter Coded Text: ");
                var code = Console.ReadLine().Trim();
                if (code.ToLowerInvariant() == "q") return;
                try
                {
                    Console.WriteLine($"Possible Decodes: {Helper.GetDecodeCount(code)}\r\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"ERROR: {e.Message}\r\n");
                }
            }
        }
    }
}
