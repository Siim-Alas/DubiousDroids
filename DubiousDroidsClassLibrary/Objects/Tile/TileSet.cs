using DubiousDroidsClassLibrary.Objects.Tile.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Tile
{
    public class TileSet : ITileSet
    {
        public ITile[] Tiles { get; private set; }

        public int[] RequestMove(int[] startPosition, int[] deltaPosition)
        {
            int[] newPosition = startPosition;
            
            for (int i = 0; i < Math.Abs(deltaPosition[0]); i++)
            {
                newPosition[0] += Math.Sign(deltaPosition[0]);
            }
            for (int j = 0; j < Math.Abs(deltaPosition[1]); j++)
            {
                newPosition[1] += Math.Sign(deltaPosition[1]);
            }

            return newPosition;
        }
    }
}
