using DubiousDroidsClassLibrary.Objects.Tile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Tile
{
    public class TileWithNeighboursRequest
    {
        public TileWithNeighboursRequest(int[] position)
        {
            Position = position;
        }
        public int[] Position { get; private set; }
        public (ITile tile, ITile[] N, ITile[] E, ITile[] S, ITile[] W) Response { get; set; }
    }
    public class MoveRequest
    {
        public MoveRequest(int[] position, int[] deltaPosition)
        {
            Position = position;
            DeltaPosition = deltaPosition;
        }
        public int[] Position { get; set; }
        public int[] DeltaPosition { get; private set; }
    }

    public class TileInfoRequestEventArgs<T> : EventArgs
    {
        public TileInfoRequestEventArgs(T request)
        {
            Request = request;
        }

        public T Request { get; set; }
    }
}
