using DubiousDroidsClassLibrary.IO;
using DubiousDroidsClassLibrary.Objects.Droid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Droid
{
    public class DroidGroup : IDroidGroup
    {
        public DroidGroup(IDroidState[] droidStates)
        {
            Droids = droidStates;
        }

        public IDroidState[] Droids { get; private set; }

        public void OnInputParsed(object source, InputParsedEventArgs args)
        {
            try
            {
                Droids[args.CommandTarget].ReceiveCommand(args);
            }
            catch
            {

            }
        }
    }
}
