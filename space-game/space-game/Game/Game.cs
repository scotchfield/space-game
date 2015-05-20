﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Enumerations;
using Space_game.Interfaces;
using Space_game.Players;

namespace Space_game.Game
{
    // Each game is an instantiation of this object.
    public class Game : IGame
    {
        private ITurn _currentTurn;
        private List<IPlayer> _players;

        public Game()
        {
            _players = new List<IPlayer>();
            _players.Add(new Player("Player1"));
            _players.Add(new Player("Player2"));
        }

        public void PlayGame()
        {
            do
            {
                _currentTurn = new Turn();
                ChooseActions(_players);
                
                 
            } while (PlayersAlive());
        }

        private void PerformActions(List<IPlayer> players)
        {
            foreach(IPlayer player in players)
            {
                player.PerformTurnAction();
            }
        }

        private void ChooseActions(List<IPlayer> players)
        {
            foreach(IPlayer player in players)
            {
                Console.WriteLine(string.Format("{0}'s turn", player.GetPlayerName()));
                player.SetAction(_currentTurn.ChooseAction());
            }
        }


        private bool PlayersAlive()
        {
            bool result = true;

            foreach(Player player in _players)
            {
                if(player.GetPlayerStatus() == PlayerStatus.Dead)
                {
                    result = false;
                }
            }

            return result;
        }


    }
}
