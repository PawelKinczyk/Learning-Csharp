using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12CSharpLearningMulticastDelegates
{
    internal class GameEventManager
    {
        //a new delegate type called GameEvent
        public delegate void GameEvent();

        //create two delegates variables called OnGameStart and OnGameOver
        public static GameEvent OnGameStart, OnGameOver;

        public static void TriggerGameStart()
        {
            //check if the OnGameStart event is not empty
            //meaning that other methods already subscribe to it
            if (OnGameStart != null)
            {
                Console.WriteLine("The game has started..");
                OnGameStart();
            }
        }

        public static void TriggerGameOver()
        {
            if (OnGameOver != null)
            {
                Console.WriteLine("The game is over");

                OnGameOver();
            }
        }
    }
}
