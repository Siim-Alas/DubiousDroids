using DubiousDroidsClassLibrary.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Droid.Interfaces
{
    public interface IDroidState
    {
        void OnInputParsed(object source, InputParsedEventArgs args);
    }
}
