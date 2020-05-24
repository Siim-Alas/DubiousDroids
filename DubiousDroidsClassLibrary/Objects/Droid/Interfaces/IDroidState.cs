using DubiousDroidsClassLibrary.IO;
using DubiousDroidsClassLibrary.Objects.Tile;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Droid.Interfaces
{
    public delegate void DroidReportStatusEventHandler(object source, DroidReportStatusEventArgs args);
    public delegate void MoveSubmittedEventHandler(object source, MoveSubmittedEventArgs args);
    public interface IDroidState
    {
        event DroidReportStatusEventHandler DroidReportedStatus;
        event MoveSubmittedEventHandler DroidSubmittedMove;
        int[] Position { get; }
        void ReceiveCommand(InputParsedEventArgs args);
        void Move(MoveReviewedEventArgs args);
    }
}
