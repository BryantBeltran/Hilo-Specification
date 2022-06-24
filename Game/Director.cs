using System;
using System.Collections.Generic;

namespace CSE210_03
{

    public class Director
    {
        private Word word = new Word();
        private bool isPlaying = true;
        private TerminalService terminalService = new TerminalService();
        public List<string> GuessesSoFar = new List<string>();
        public string letter = "_";
        

        private JumperNew manley = new JumperNew();

        public Director()
        {
        }

        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }
        private void GetInputs()
        {
            word.PrintGuessesSoFar();
            manley.PrintChute();
            manley.PrintPerson();
            List<string> GuessesSoFar = word.CreateUnderscore();
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