using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Tile.Interfaces
{
    public delegate void TileInfoRequestedEventHandler(object source, TileInfoRequestEventArgs args);
    public interface ITileSet
    {
        ITile[,] Tiles { get; }
        (ITile tile, ITile[] N, ITile[] E, ITile[] S, ITile[] W) GetTileWithNeighbours(int[] position);
        int[] RequestMove(int[] startPosition, int[] deltaPosition);
        void OnTileInfoRequested(object source, TileInfoRequestEventArgs args);
    }
}
