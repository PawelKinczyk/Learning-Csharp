using System;

namespace Chapter12CSharpLearningMulticastDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create audio system
            AudioSystem audioSystem = new AudioSystem();
            // create a rendering engine
            RenderingEngine renderingEngine = new RenderingEngine();
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilv");
            Player player3 = new Player("Tom");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is running... press any key to end game");

            Console.ReadLine();

            GameEventManager.TriggerGameOver();

        }
    }
}
