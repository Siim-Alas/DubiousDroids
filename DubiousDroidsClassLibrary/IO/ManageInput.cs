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
            try
            {
                string[] inputArray = input.Split(' ');

                if (Enum.TryParse(inputArray[1], out InputParsedEventArgs.InstructionsEnum instructions))
                {
                    if (Enum.IsDefined(typeof(InputParsedEventArgs.InstructionsEnum), instructions))
                    {
                        int commandTarget = Convert.ToInt32(inputArray[0]);

                        InputParsed(this, new InputParsedEventArgs(commandTarget, instructions, (inputArray.Length > 2) ? inputArray[2] : ""));
                    }
                }
            }
            catch
            {

            }
        }
    }
}
