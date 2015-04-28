using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Enumerations;
using Space_game.Interfaces;

namespace Space_game.Game
{
    class Turn : ITurn
    {
        public TurnActions ChooseAction()
        {
            TurnActions? turnAction;

            do
            {
                DisplayTurnActions();
                turnAction = PlayerChoice();
            } while (!IsValidChoice(turnAction));

            return (TurnActions)turnAction;
        }

        public void UsePlayedCard()
        {

        }

        private void BeginTurn()
        {

        }

        private void EndTurn()
        {

        }

        private void DisplayTurnActions()
        {
            Console.WriteLine("Choose your action:");
            Console.WriteLine("1. Gain 2 Energy");
            Console.WriteLine("2. Gain 1 Energy, draw a Card");
            Console.WriteLine("3. Play a card");
        }

        private TurnActions? PlayerChoice()
        {
            TurnActions? result = null;
            int choice;
            choice = Console.Read();
            choice = choice - 48;
            if(choice < 4 && choice > 0)
            {
                result = (TurnActions)choice;
            }
            return result;
        }

        private bool IsValidChoice(TurnActions? choice)
        {
            bool result = (choice != null);

            if(!result)
            {
                Console.WriteLine("Incorrect input, please try again");
                Console.WriteLine();
            }
            return result;
        }
    }
}
