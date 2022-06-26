using System;
using System.Collections.Generic;


namespace CSE210_03
{

    public class Word
    {
       
        List<string> GuessesSoFar = new List<string>();
        
        private List<string> Words = new List<string>
        {
            "Church", "Book", "Nephi", "Manley", "Rexburg", "Utah", "Amulek", "Enos", "Helaman", "Jacob"
        };
        private string ToBeGuessed= "";

        public Word()
        {
        }

        
        public string PullWord(){
            Random random = new Random();
            int index = random.Next(Words.Count);
            ToBeGuessed = Words[index];
            return ToBeGuessed;
        }

        public List<string> CreateUnderscore()
        {
            foreach (int i in GuessesSoFar)
            {
                GuessesSoFar.Add("_");
            }
            return GuessesSoFar;
        }

        public void PrintGuessesSoFar(){
            foreach (string s in GuessesSoFar) {
                Console.Write($"{s} ");
            }
        }

        public bool CompareLettertoWord(string letter) {

            bool found = false;

            for (int i = 0;  i <  ToBeGuessed.Length; i ++)
            {
                string current_letter = char.ToString(ToBeGuessed[i]);
                
                if (current_letter == letter)
                {
                    found = true;
                    GuessesSoFar[i] = current_letter;
                }
            }

            return found;
            
        }
       

        /// <returns>True if found; false if otherwise.</returns>
        public bool IsFound(List<string> GuessesSoFar)
        {
            foreach(string c in GuessesSoFar)
            {
                if (c != "_"){
                    
                }

            }
            return true;
        }


        
    }
}
