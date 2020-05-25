using DubiousDroidsClassLibrary.Objects.Tile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Tile
{
    public class TileInfoRequestEventArgs : EventArgs
    {
        public TileInfoRequestEventArgs(OptionsEnum request, int[] position, int[] deltaPosition)
        {
            Request = request;
            Position = position;
            DeltaPosition = deltaPosition;
        }
        public enum OptionsEnum
        {
            TileWithNeighbors,
            Move
        }
        public OptionsEnum Request { get; private set; }
        public int[] Position { get; set; }

        // TileWithNeighbours
        public (ITile tile, ITile[] N, ITile[] E, ITile[] S, ITile[] W) TileWithNeighboursResponse { get; set; }

        // Move
        public int[] DeltaPosition { get; set; }
    }
}
