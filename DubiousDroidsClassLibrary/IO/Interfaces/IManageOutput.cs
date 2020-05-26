using DubiousDroidsClassLibrary.Objects.Droid;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.IO.Interfaces
{
    public delegate void OutputManagerUpdatedEventHandler(object source, EventArgs args);
    public interface IManageOutput
    {
        event OutputManagerUpdatedEventHandler OutputManagerUpdated;
        string[,] DisplayedTiles { get; }
        void OnDroidReportedStatus(object source, DroidReportStatusEventArgs args);
    }
}
