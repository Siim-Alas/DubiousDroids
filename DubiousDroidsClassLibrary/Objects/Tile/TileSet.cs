using DubiousDroidsClassLibrary.Objects.Tile.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Tile
{
    public class TileSet : ITileSet
    {
        public event MoveReviewedEventHandler MoveReviewed;
        public ITile[] Tiles { get; private set; }

        public void OnDroidSubmittedMove(object source, MoveSubmittedEventArgs args)
        {
            int[] newPosition = args.StartPosition;
            
            for (int i = 0; i < Math.Abs(args.DeltaPosition[0]); i++)
            {
                newPosition[0] += Math.Sign(args.DeltaPosition[0]);
            }
            for (int j = 0; j < Math.Abs(args.DeltaPosition[1]); j++)
            {
                newPosition[1] += Math.Sign(args.DeltaPosition[1]);
            }

            MoveReviewed(this, new MoveReviewedEventArgs(args.ID, newPosition));
        }
    }
}
