using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12CSharpLearningMulticastDelegates
{
    internal class Player
    {
        public string PlayerName { get; set; }

        public Player(string name)
        {
            this.PlayerName = name;
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }
        public void StartGame()
        {
            Console.WriteLine($"Spawning player with ID: {PlayerName}");
        }
        private void GameOver()
        {
            Console.WriteLine($"Removing player with id: {PlayerName}");
        }
    }
}
