using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12CSharpLearningMulticastDelegates
{
    internal class AudioSystem
    {

        public AudioSystem() {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameStart += GameOver;
        }
        private void StartGame()
        {
            Console.WriteLine("Audio system started");
            Console.WriteLine("Playing audio...");
        }
        private void GameOver()
        {
            Console.WriteLine("Audio system stopped");
        }
    }
}
