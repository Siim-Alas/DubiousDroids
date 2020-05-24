using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Tile
{
    public class MoveSubmittedEventArgs : EventArgs
    {
        public MoveSubmittedEventArgs(int id, int[] startPosition, int[] deltaPosition)
        {
            ID = id;
            StartPosition = startPosition;
            DeltaPosition = deltaPosition;
        }
        public int ID { get; private set; }
        public int[] StartPosition { get; private set; }
        public int[] DeltaPosition { get; private set; }
    }
}
