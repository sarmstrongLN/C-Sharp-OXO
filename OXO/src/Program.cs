﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXO
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying;
            do
            {
                Game game = new Game();
                keepPlaying = game.run();
            } while (keepPlaying);
        }
    }
}
