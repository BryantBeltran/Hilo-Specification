using System;
using System.Collections.Generic;
using System.Linq;


namespace CSE210_03
{

    public class Word
    {
       
        List<char> GuessesSoFar = new List<char>();
        List<char> answer = new List<char>();
        
        public List<string> Words = new List<string>
        {
            "Church", "Book", "Nephi", "Manley", "Rexburg", "Utah", "Amulek", "Enos", "Helaman", "Jacob"
        };
        public string ToBeGuessed= "";

        public Word()
        {
        }

        
        public string GenerateNewWord(){
            Random random = new Random();
            int index = random.Next(Words.Count);
            ToBeGuessed = Words[index];
            return ToBeGuessed;
        }

        public void MakeWordAList(string TBGuess){
            answer.AddRange(TBGuess.ToLower());
        }

        public void CreateUnderscoreWord()
        {
            foreach (int i in answer)
            {
                GuessesSoFar.Add('_');
            }
        }

        public void PrintGuessesSoFar(){
            Console.WriteLine(string.Format("{0}", string.Join(" ", GuessesSoFar)));       
        }

        public int Compare(string letter){
            for(int i=0;i<answer.Count;i++){
                if (letter.Contains(answer[i])){
                    GuessesSoFar[i] = answer[i];}}
            if (answer.Contains(char.Parse(letter))){
                return 0;}
            else {
                return 1;}

        }

        public int checkbothlists(){
        bool isEqual = Enumerable.SequenceEqual(answer, GuessesSoFar);
        if (isEqual) {
            return 1;
        }
        else {
            return 0;
        }
        }


        
    }
}
