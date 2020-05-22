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
        private IDroidState[] droids;

        public IManageInput InputManager { get; private set; }
        public IManageOutput OutputManager { get; private set; }

        public GameState()
        {
            InputManager = new ManageInput();
            OutputManager = new ManageOutput();

            IDroidState rs = new ReadyState();

            InputManager.InputParsed += rs.OnInputParsed;
        }
    }
}
