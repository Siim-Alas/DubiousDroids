using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.IO
{
    public class InputParsedEventArgs : EventArgs
    {
        public string[] Instructions { get; set; }
    }
}
