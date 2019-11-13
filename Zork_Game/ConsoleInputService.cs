using System;
using System.Collections.Generic;
using System.Text;
using Zork_Common;

namespace Zork_Game
{
    internal class ConsoleInputService : IInputService
    {
        public event EventHandler<string> InputReceived;

        public void ProcessInput()
        {
            string Inputstring = Console.ReadLine().Trim();
            InputReceived.Invoke(this, Inputstring);
        }
    }
}
