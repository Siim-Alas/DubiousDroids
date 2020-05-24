using DubiousDroidsClassLibrary.IO.Interfaces;
using DubiousDroidsClassLibrary.Objects.Droid;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DubiousDroidsClassLibrary.IO
{
    public class ManageOutput : IManageOutput
    {
        public void OnDroidReportedStatus(object source, DroidReportStatusEventArgs args)
        {
            Console.WriteLine($"ID = {args.ID}; Position = {string.Join(", ", args.Position)}; Direction = {args.Direction}");
        }
    }
}
