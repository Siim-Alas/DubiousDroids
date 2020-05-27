using System;
using System.Collections.Generic;
using System.Text;
using static DubiousDroidsClassLibrary.Objects.Tile.JunctionTile;

namespace DubiousDroidsClassLibrary.Objects.Tile.Interfaces
{
    public interface ITile
    {
        JunctionTypeEnum JunctionType { get; }
    }
}
