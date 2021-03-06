﻿using System;
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
        public void PlayTurn(List<IPlayer> players)
        {
            foreach (IPlayer player in players)
            {
                Console.WriteLine(string.Format("{0}'s turn", player.GetPlayerName()));
                player.SetAction(this.ChooseAction());
                player.PerformTurnAction();
            }
        }

        public TurnActions ChooseAction()
        {
            TurnActions? turnAction;
            do
            {
                DisplayTurnActions();
                turnAction = PlayerChoice();
            } while (IsValidChoice(turnAction));

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
            TurnActions? result;
            int choice;
            choice = ReadPlayerInput();
            if(choice < 4 && choice > 0)
            {
                Console.WriteLine();
                result = (TurnActions)choice;
            }
            else
            {
                result = null;
            }
            return result;
        }

        private int ReadPlayerInput()
        {
            int result;

            try
            {
                result = Convert.ToInt32(Console.ReadLine().ToString().Trim());
            }
            catch (Exception)
            {
                result = 0;
            }

            return result;
        }

        private bool IsValidChoice(TurnActions? choice)
        {
            bool result = (choice == null);

            if(result)
            {
                Console.WriteLine("Incorrect input, please try again");
                Console.WriteLine();
            }
            return !result;
        }
    }
}
