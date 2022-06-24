using System;
using System.Collections.Generic;

namespace CSE210_03
{
   
    public class TerminalService
    {
       
        public TerminalService()
        {
        }

        
        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        
       
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}