using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Tile.Interfaces
{
    public delegate void TileInfoRequestedEventHandler<T>(object source, TileInfoRequestEventArgs<T> args);
    public interface ITileSet
    {
        ITile[,] Tiles { get; }
        void OnTileInfoRequested(object source, TileInfoRequestEventArgs<TileWithNeighboursRequest> args);
        void OnTileInfoRequested(object source, TileInfoRequestEventArgs<MoveRequest> args);
    }
}
