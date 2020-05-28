using DubiousDroidsClassLibrary.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

                        Task.Run(async delegate
                        {
                            await Task.Delay(1000);
                            InputParsed(this, new InputParsedEventArgs(commandTarget, instructions, (inputArray.Length > 2) ? inputArray[2] : ""));
                        });
                    }
                }
            }
            catch (Exception ex) when 
            (ex is ArgumentException || 
            ex is ArgumentNullException || 
            ex is FormatException || 
            ex is OverflowException)
            {

            }
        }
    }
}
