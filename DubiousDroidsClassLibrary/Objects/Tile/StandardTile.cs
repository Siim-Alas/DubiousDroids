using DubiousDroidsClassLibrary.Objects.Tile.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using static DubiousDroidsClassLibrary.Objects.Tile.JunctionTile;

namespace DubiousDroidsClassLibrary.Objects.Tile
{
    public class StandardTile : ITile
    {
        public JunctionTypeEnum JunctionType { get { return JunctionTypeEnum.None; } }
    }
}
