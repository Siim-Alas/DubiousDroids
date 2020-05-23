using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.IO
{
    public class InputParsedEventArgs : EventArgs
    {
        public InputParsedEventArgs(int commandTarget, InstructionsEnum instructions, int argument)
        {
            CommandTarget = commandTarget;
            Instructions = instructions;
            Argument = argument;
        }
        public int CommandTarget { get; set; }
        public enum InstructionsEnum
        {
            peek,
            move
        }
        public InstructionsEnum Instructions { get; set; }
        public int Argument { get; set; }
    }
}
