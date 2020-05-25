using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Tile.Interfaces
{
    public interface ITileSet
    {
        ITile[,] Tiles { get; }
        int[] RequestMove(int[] startPosition, int[] deltaPosition);
    }
}
