using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.IO
{
    public class InputParsedEventArgs : EventArgs
    {
        public InputParsedEventArgs(int commandTarget, InstructionsEnum instructions, string argument)
        {
            CommandTarget = commandTarget;
            Instructions = instructions;
            Argument = argument;
        }

        public int CommandTarget { get; private set; }
        public enum InstructionsEnum
        {
            peek,
            turn,
            move
        }
        public InstructionsEnum Instructions { get; private set; }
        public string Argument { get; private set; }
    }
}
