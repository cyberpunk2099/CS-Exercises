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
            Console.WriteLine(" - To exit: 0 \r\n");
            while (true)
            {
                Console.Write("Enter Coded Text: ");
                var code = Console.ReadLine().Trim();
                if (code == "0") return;
                Console.Write(
                    $"Possible Decodes: {Calc.GetNumberOfDecodes(code).ToString("#,##0")}\r\n\r\n");
            }
        }
    }
}
