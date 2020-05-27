using DubiousDroidsClassLibrary.Objects.Tile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Tile
{
    public class JunctionTile : ITile
    {
        public JunctionTile(JunctionTypeEnum junctionType)
        {
            JunctionType = junctionType;
        }
        public enum JunctionTypeEnum
        {
            None,
            NE,
            NW,
            SE,
            SW,
            NES,
            SWN,
            ESW,
            WNE,
            Cross
        }
        public JunctionTypeEnum JunctionType { get; private set; }
    }
}
