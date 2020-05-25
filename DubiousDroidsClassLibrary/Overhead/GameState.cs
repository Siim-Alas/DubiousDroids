using DubiousDroidsClassLibrary.IO;
using DubiousDroidsClassLibrary.IO.Interfaces;
using DubiousDroidsClassLibrary.Objects.Droid;
using DubiousDroidsClassLibrary.Objects.Droid.Interfaces;
using DubiousDroidsClassLibrary.Objects.Tile;
using DubiousDroidsClassLibrary.Objects.Tile.Interfaces;
using DubiousDroidsClassLibrary.Overhead.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DubiousDroidsClassLibrary.Overhead
{
    public class GameState : IGameState
    {
        public IManageInput InputManager { get; private set; }
        public IManageOutput OutputManager { get; private set; }

        private readonly ITileSet tileSet;
        private readonly IDroidGroup droidGroup;

        public GameState()
        {
            InputManager = new ManageInput();
            tileSet = new TileSet();
            OutputManager = new ManageOutput(tileSet);
            droidGroup = new DroidGroup(new IDroidState[] { 
                new ReadyState(new int[] { 0, 0 }, new int[] { 1, 0 }),
                new ReadyState(new int[] { 2, 3 }, new int[] { 0, 1 })
            });

            InputManager.InputParsed += droidGroup.OnInputParsed;
            foreach (IDroidState droid in droidGroup.Droids)
            {
                droid.DroidReportedStatus += OutputManager.OnDroidReportedStatus;
                droid.TileInfoRequested += tileSet.OnTileInfoRequested;
            }
        }
    }
}
