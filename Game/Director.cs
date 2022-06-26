using System;
using System.Collections.Generic;

namespace CSE210_03
{

    public class Director
    {
    
        private bool isPlaying = true;
        private string ToBeGuessed;
        public Word word = new Word();
        public TerminalService terminalService = new TerminalService();
        
        public JumperNew manley = new JumperNew();
        public string letter = "_";
       
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
            manley.PrintChute();
            manley.PrintPerson();
            letter = terminalService.ReadText("Guess a Letter [a-z]: ");
        }

        private void DoUpdates()
        {
            int LoseOrWin = word.Compare(letter);
            if (LoseOrWin == 1)
            {
                manley.CutChute();
            }
            isPlaying = !manley.IsDead();
        }
        private void DoOutputs()
        { 
            int gameOver = word.checkbothlists();
            if (gameOver == 1){
                isPlaying = false;
            }
            Console.WriteLine("\n");
            if (isPlaying){
                word.PrintGuessesSoFar();
            }
            else {
                word.PrintGuessesSoFar();
                if (!manley.IsDead())
                {
                    Console.WriteLine("\n YOU WON! BRO MANLEY is the BEST");
                }
                else
                {
                    Console.WriteLine("\n YOU LOSE. Ah chute.");
                }
            }


        }
    }
}