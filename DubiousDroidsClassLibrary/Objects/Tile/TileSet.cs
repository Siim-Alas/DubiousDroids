using DubiousDroidsClassLibrary.Objects.Tile.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Tile
{
    public class TileSet : ITileSet
    {
        private readonly StandardTile st = new StandardTile(StandardTile.JunctionTypeEnum.None);
        private readonly StandardTile wne = new StandardTile(StandardTile.JunctionTypeEnum.WNE);

        private readonly List<ITile> passableTiles = new List<ITile>();

        public TileSet()
        {
            Tiles = new ITile[,]
            {
                {st, st, null, null, null },
                {null, null, null, null, null },
                {null, null, st, null, null },
                {null, null, st, null, null },
                {null, st, wne, st, null },
                {null, null, null, null, null }
            };

            passableTiles.Add(st);
            passableTiles.Add(wne);
        }
        public ITile[,] Tiles { get; private set; }

        private (ITile tile, ITile[] N, ITile[] E, ITile[] S, ITile[] W) GetTileWithNeighbours(int[] position)
        {
            // Accessing arrays is [row, column], which, for the sake of convenience, is also [y, x]
            ITile tile = Tiles[position[1], position[0]];
            List<ITile> N = new List<ITile>(), E = new List<ITile>(), S = new List<ITile>(), W = new List<ITile>();

            int x = position[0];
            int y = position[1];
            try
            {
                while (Tiles[--y, x] != null)
                {
                    N.Add(Tiles[y, x]);
                }
            }
            catch (IndexOutOfRangeException) { }
            y = position[1];
            try
            {
                while (Tiles[++y, x] != null)
                {
                    S.Add(Tiles[y, x]);
                }
            }
            catch (IndexOutOfRangeException) { }
            y = position[1];
            try
            {
                while (Tiles[y, ++x] != null)
                {
                    E.Add(Tiles[y, x]);
                }
            }
            catch (IndexOutOfRangeException) { }
            x = position[0];
            try
            {
                while (Tiles[y, --x] != null)
                {
                    W.Add(Tiles[y, x]);
                }
            }
            catch (IndexOutOfRangeException) { }

            return (tile, N.ToArray(), E.ToArray(), S.ToArray(), W.ToArray());
        }

        private int[] RequestMove(int[] startPosition, int[] deltaPosition)
        {
            int[] newPosition = startPosition;

            // Accessing arrays is [row, column], which, for the sake of convenience, is also [y, x]
            for (int i = 0; i < Math.Abs(deltaPosition[0]); i++)
            {
                if (passableTiles.Contains(Tiles[newPosition[1], newPosition[0] + Math.Sign(deltaPosition[0])]))
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
                if (passableTiles.Contains(Tiles[newPosition[1] + Math.Sign(deltaPosition[1]), newPosition[0]]))
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

        public void OnTileInfoRequested(object source, TileInfoRequestEventArgs<TileWithNeighboursRequest> args)
        {
            args.Request.Response = GetTileWithNeighbours(args.Request.Position);
        }
        public void OnTileInfoRequested(object source, TileInfoRequestEventArgs<MoveRequest> args)
        {
            args.Request.Position = RequestMove(args.Request.Position, args.Request.DeltaPosition);
        }
    }
}
