using DubiousDroidsClassLibrary.IO.Interfaces;
using DubiousDroidsClassLibrary.Objects.Droid.Interfaces;
using DubiousDroidsClassLibrary.Objects.Tile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Overhead.Interfaces
{
    public interface IGameState
    {
        IManageInput InputManager { get; }
        IManageOutput OutputManager { get; }
    }
}
