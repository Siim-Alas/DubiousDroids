using DubiousDroidsClassLibrary.Objects.Droid;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.IO.Interfaces
{
    public interface IManageOutput
    {
        void OnDroidReportedStatus(object source, DroidReportStatusEventArgs args);
    }
}
