﻿
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Zork_Common;

namespace Zork_Common 
{
    class Program
    {

        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            Game game = Game.Load(gameFilename);
            Console.WriteLine("Welcome to Zork!");
            game.Run();
            Console.WriteLine("Thanks for playing!");
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }

    }

}


