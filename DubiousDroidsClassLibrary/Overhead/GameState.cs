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
        public IDroidGroup DroidGroup { get; private set; }

        public GameState()
        {
            InputManager = new ManageInput();
            OutputManager = new ManageOutput();

            DroidGroup = new DroidGroup(new IDroidState[] { 
                new ReadyState()
            });

            InputManager.InputParsed += DroidGroup.OnInputParsed;
            foreach (IDroidState droid in DroidGroup.Droids)
            {
                droid.DroidReportedStatus += OutputManager.OnDroidReportedStatus;
            }
        }
    }
}
