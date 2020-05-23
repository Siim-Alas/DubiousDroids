using DubiousDroidsClassLibrary.IO;
using DubiousDroidsClassLibrary.IO.Interfaces;
using DubiousDroidsClassLibrary.Objects.Droid;
using DubiousDroidsClassLibrary.Objects.Droid.Interfaces;
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
        public IDroidGroup Droids { get; private set; }

        public GameState()
        {
            InputManager = new ManageInput();
            OutputManager = new ManageOutput();

            Droids = new DroidGroup(new IDroidState[] { 
                new ReadyState()
            });

            InputManager.InputParsed += Droids.OnInputParsed;
        }
    }
}
