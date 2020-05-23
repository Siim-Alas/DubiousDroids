using DubiousDroidsClassLibrary.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.IO
{
    public class ManageInput : IManageInput
    {
        public event InputParsedEventHandler InputParsed;

        public void ParseTextInput(string input)
        {
            string[] inputArray = input.Split(' ');
            InputParsed(this, new InputParsedEventArgs() { Instructions = inputArray });
        }
    }
}
