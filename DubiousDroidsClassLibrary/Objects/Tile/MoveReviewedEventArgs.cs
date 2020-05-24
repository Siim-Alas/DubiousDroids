using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Tile
{
    public class MoveReviewedEventArgs : EventArgs
    {
        public MoveReviewedEventArgs(int commandTarget, int[] newPosition)
        {
            CommandTarget = commandTarget;
            NewPosition = newPosition;
        }
        public int CommandTarget { get; private set; }
        public int[] NewPosition { get; private set; }
    }
}
