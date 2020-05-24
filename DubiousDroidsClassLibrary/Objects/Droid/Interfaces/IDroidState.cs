using DubiousDroidsClassLibrary.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Droid.Interfaces
{
    public delegate void DroidReportStatusEventHandler(object source, DroidReportStatusEventArgs args);
    public interface IDroidState
    {
        event DroidReportStatusEventHandler DroidReportedStatus;
        int[] Position { get; }
        void ReceiveCommand(InputParsedEventArgs args);
    }
}
