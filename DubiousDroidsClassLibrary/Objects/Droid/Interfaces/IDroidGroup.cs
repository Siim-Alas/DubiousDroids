using DubiousDroidsClassLibrary.IO;
using DubiousDroidsClassLibrary.Objects.Tile;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Droid.Interfaces
{
    public interface IDroidGroup
    {
        IDroidState[] Droids { get; }
        void OnInputParsed(object source, InputParsedEventArgs args);
    }
}
