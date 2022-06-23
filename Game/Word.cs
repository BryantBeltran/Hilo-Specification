using System;
using System.Collections.Generic;


namespace CSE210_03
{
    /// <summary>
    /// <para>The hidden word to be guessed.</para>
    /// <para>
    /// The responsibility of Word is to keep track of the letters coming from the Letter file.
    /// </para>
    /// </summary>
    public class Word
    {
        public string Letter = "";
        List<char> GuessesSoFar = new List<char>();
        
        private List<string> Words = new List<string>
        {
            "Church", "Book", "Nephi", "Manley", "Rexburg", "Utah", "Amulek", "Enos", "Helaman", "Jacob"
        };
        private string ToBeGuessed= "";

        public string GetToBeGuessed()
        {
          return ToBeGuessed;
         }

        public void SetToBeGuessed(string NewWordTBGuessed)
         {
            ToBeGuessed = NewWordTBGuessed;
         }


        /// <summary>
        /// Constructs a new instance of Word. 
        /// </summary>
        public Word()
        {
            Random random = new Random();
            int index = random.Next(Words.Count);
            ToBeGuessed = Words[index];
        }

        public void ChangeLetter(char letter)
        {
            this.Letter = letter;
        }


        public void CreateEmptyWord(string Word)
        {
            GuessesSoFar.AddRange(Word);
            foreach (char c in GuessesSoFar)
            {
                GuessesSoFar[c] = '_';
            }
        }
       
        /// <summary>
        /// Whether or not the hider has been found.
        /// </summary>
        /// <returns>True if found; false if otherwise.</returns>
        public bool IsFound(List<char> GuessesSoFar)
        {
            foreach(char c in GuessesSoFar)
            {
                if (c != '_'){
                    
                }

            }
            return true;
        }


        
        }
    }
