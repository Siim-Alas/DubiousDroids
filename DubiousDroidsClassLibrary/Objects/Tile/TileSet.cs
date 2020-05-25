using DubiousDroidsClassLibrary.Objects.Tile.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Tile
{
    public class TileSet : ITileSet
    {
        private readonly StandardTile st = new StandardTile();
        public TileSet()
        {
            Tiles = new ITile[,]
            {
                {st, st, null, null, null },
                {null, null, null, null, null },
                {null, null, null, st, null },
                {null, null, null, st, null },
                {null, st, st, st, null },
                {null, null, null, null, null }
            };
        }
        public ITile[,] Tiles { get; private set; }

        public int[] RequestMove(int[] startPosition, int[] deltaPosition)
        {
            int[] newPosition = startPosition;

            // Accessing arrays is [row, column], which, for the sake of convenience, is also [y, x]
            for (int i = 0; i < Math.Abs(deltaPosition[0]); i++)
            {
                if (Tiles[newPosition[1], newPosition[0] + Math.Sign(deltaPosition[0])] == st)
                {
                    newPosition[0] += Math.Sign(deltaPosition[0]);
                }
                else
                {
                    break;
                }
            }
            for (int j = 0; j < Math.Abs(deltaPosition[1]); j++)
            {
                if (Tiles[newPosition[1] + Math.Sign(deltaPosition[1]), newPosition[0]] == st)
                {
                    newPosition[1] += Math.Sign(deltaPosition[1]);
                }
                else
                {
                    break;
                }
            }

            return newPosition;
        }
    }
}
