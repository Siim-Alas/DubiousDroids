using DubiousDroidsClassLibrary.IO.Interfaces;
using DubiousDroidsClassLibrary.Objects.Droid;
using DubiousDroidsClassLibrary.Objects.Droid.Interfaces;
using DubiousDroidsClassLibrary.Objects.Tile.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DubiousDroidsClassLibrary.IO
{
    public class ManageOutput : IManageOutput
    {
        public ManageOutput(ITileSet tileSet)
        {
            CurrentDroidReports = new List<DroidReportStatusEventArgs>();
            DisplayedTiles = new string[tileSet.Tiles.GetLength(0), tileSet.Tiles.GetLength(1)];
        }

        public event OutputManagerUpdatedEventHandler OutputManagerUpdated;

        public List<DroidReportStatusEventArgs> CurrentDroidReports { get; private set; }
        public string[,] DisplayedTiles { get; private set; }

        public void OnDroidReportedStatus(object source, DroidReportStatusEventArgs args)
        {
            Console.WriteLine($"droid {args.ID} reported position ({string.Join(';', args.Position)}) facing {args.Direction} ");
            CurrentDroidReports.Add(args);
            DisplayedTiles[args.Position[1], args.Position[0]] = "droid";

            OutputManagerUpdated(this, EventArgs.Empty);
        }
    }
}
