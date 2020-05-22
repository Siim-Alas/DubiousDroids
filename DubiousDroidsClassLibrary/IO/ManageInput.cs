using DubiousDroidsClassLibrary.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.IO
{
    public class ManageInput : IManageInput
    {
        public event InputParsedEventHandler InputParsed;

        public ManageInput()
        {

        }

        public void ParseTextInput(string input)
        {
            InputParsed(this, EventArgs.Empty);
        }
    }
}
