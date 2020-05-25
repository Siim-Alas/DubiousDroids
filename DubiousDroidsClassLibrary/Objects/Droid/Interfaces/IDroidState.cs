using DubiousDroidsClassLibrary.IO;
using DubiousDroidsClassLibrary.Objects.Tile;
using DubiousDroidsClassLibrary.Objects.Tile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Droid.Interfaces
{
    public delegate void DroidReportStatusEventHandler(object source, DroidReportStatusEventArgs args);
    public interface IDroidState
    {
        event DroidReportStatusEventHandler DroidReportedStatus;
        event TileInfoRequestedEventHandler TileInfoRequested;
        int[] Position { get; }
        void ReceiveCommand(InputParsedEventArgs args);
    }
}
