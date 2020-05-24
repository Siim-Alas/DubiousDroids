using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Droid
{
    public class DroidReportStatusEventArgs : EventArgs
    {
        public DroidReportStatusEventArgs(int id, int[] position, DirectionEnum direction)
        {
            ID = id;
            Position = position;
            Direction = direction;
        }

        public int ID { get; private set; }
        public int[] Position { get; private set; }
        public enum DirectionEnum
        {
            none,
            N,
            E,
            S,
            W
        }
        public DirectionEnum Direction { get; private set; }

    }
}
