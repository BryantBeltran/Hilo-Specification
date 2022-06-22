using System;

namespace cse210_03 // Note: actual namespace depends on the project name.
{
    internal class TerminalService
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void PrintList(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}