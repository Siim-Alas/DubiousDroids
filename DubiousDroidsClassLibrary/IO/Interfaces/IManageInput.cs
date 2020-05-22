using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.IO.Interfaces
{
    public delegate void InputParsedEventHandler(object source, EventArgs args);
    public interface IManageInput
    {
        event InputParsedEventHandler InputParsed;
        void ParseTextInput(string input);
    }
}
