﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Interfaces;
using Space_game.Enumerations;

namespace Space_game.Players
{
    class Player : IPlayer
    {
        public string PlayerName { get; private set; }

        int totalEnergy;
        int maxEnergy = 10;

        int Hullpoints;
        PlayerDeck Deck;
        PlayerHand Hand;
        PlayerStatus DeadOrAlive;
        PlayedCards CardsInPlay;
        private TurnActions _action;

        public Player(string playerName)
        {
            PlayerName = playerName;
            totalEnergy = 2;
            DeadOrAlive = PlayerStatus.Alive;
            Deck = new PlayerDeck();
            Hand = new PlayerHand();
        }

        public PlayerStatus GetPlayerStatus()
        {
            return DeadOrAlive;
        }

        public void SetAction(TurnActions action)
        {
            _action = action;
        }

        public void RemoveHullPoints(int damage)
        {
            this.Hullpoints -= damage;
            if(Hullpoints <= 0)
            {
                DeadOrAlive = PlayerStatus.Dead;
            }
        }

        public int GetHullPoints()
        {
            return Hullpoints;
        }

        public string GetPlayerName()
        {
            return PlayerName;
        }

        public void PerformTurnAction()
        {
            switch(_action)
            {
                case TurnActions.Gain2Energy:
                    totalEnergy += 2;
                    if (totalEnergy > maxEnergy)
                    {
                        totalEnergy = maxEnergy;
                    }
                    break;
                case TurnActions.Gain1Energy1Card:
                    totalEnergy += 1;
                    DrawCards(1);
                    break;
                case TurnActions.PlayCard:
                    PutCardInPlay();
                    break;
                default:
                    break;

            }
        }

        private void PutCardInPlay()
        {
            int choice;

            Console.WriteLine("Choose card to play:");
            Hand.DisplayPlayerHand();
            choice = Convert.ToInt32(Console.ReadLine().ToString().Trim());

            CardsInPlay.PutInPlay(Hand.At(choice));
        }

        public void DisplayPlayerInformation()
        {
            Console.WriteLine(string.Format("Hullpoints: {0}\tEnergy: {1}", Hullpoints, totalEnergy));
        }

        private void DrawCards(int nCards)
        {
            ICardRepresentation result = Deck.DrawTopCard();
            Hand.AddCard(result);
        }

    }
}
