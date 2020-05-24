using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Tile.Interfaces
{
    public delegate void MoveReviewedEventHandler(object source, MoveReviewedEventArgs args);
    public interface ITileSet
    {
        event MoveReviewedEventHandler MoveReviewed;
        ITile[] Tiles { get; }
        void OnDroidSubmittedMove(object source, MoveSubmittedEventArgs args);
    }
}
