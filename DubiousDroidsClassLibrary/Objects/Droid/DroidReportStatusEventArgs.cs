using DubiousDroidsClassLibrary.Objects.Tile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Droid
{
    public class DroidReportStatusEventArgs : EventArgs
    {
        public DroidReportStatusEventArgs(int id, int[] position, DirectionEnum direction, 
                                         (ITile tile, ITile[] N, ITile[] E, ITile[] S, ITile[] W) tileInfo)
        {
            ID = id;
            Position = position;
            Direction = direction;
            TileInfo = tileInfo;
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
        public (ITile tile, ITile[] N, ITile[] E, ITile[] S, ITile[] W) TileInfo { get; private set; }
    }
}
