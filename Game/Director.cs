using System;
using System.Collections.Generic;

namespace CSE210_03
{

    public class Director
    {
    
        private bool isPlaying = true;
        private Word word = new Word();
        private TerminalService terminalService = new TerminalService();
        public List<string> GuessesSoFar = new List<string>();
        public string letter = "_";
        public string ToBeGuessed;
        

        public JumperNew manley = new JumperNew();

        public Director()
        {
        }

        public void StartGame()
        {   Initialize();
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        private void Initialize(){
            ToBeGuessed = word.GenerateNewWord();
            word.MakeWordAList(ToBeGuessed);
            word.CreateUnderscoreWord();
            word.PrintGuessesSoFar();
        }
        private void GetInputs()
        {
            Console.WriteLine("\n");
            word.PrintGuessesSoFar();
            manley.PrintChute();
            manley.PrintPerson();
            string letter = terminalService.ReadText("Guess a Letter [a-z]: ");
        }

        private void DoUpdates()
        {
            bool foundALetter = word.CompareLettertoWord(letter);
            if (foundALetter == false)
            {
                manley.CutChute();
            }
            isPlaying = !manley.IsDead();
        }
        private void DoOutputs()
        {
            if (!isPlaying){
                Console.WriteLine("You Lost, Todd is the best Programmer");
            }
            
        }
    }
}