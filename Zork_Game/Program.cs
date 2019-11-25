
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Zork_Common;

namespace Zork_Game 
{
    class Program
    {

        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            ConsoleOutputService output = new ConsoleOutputService();
            Game game = Game.LoadFromFile(gameFilename, output);

            //Game game = Game.Load(gameFilename);
            output.WriteLine("Welcome to Zork!");
            game.Run();
            output.WriteLine("Thanks for playing!");
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }

    }

}


