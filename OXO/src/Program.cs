using System;

namespace OXO
{
    class Program
    {
        static void Main(string[] args) {
            bool keepPlaying;
            do {
                Game game = new Game();
                keepPlaying = game.run();
            } while (keepPlaying);
        }
    }
}
