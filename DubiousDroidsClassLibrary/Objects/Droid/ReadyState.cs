using DubiousDroidsClassLibrary.Objects.Droid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Droid
{
    public class ReadyState : IDroidState
    {
        public void OnInputParsed(object source, EventArgs args)
        {
            Console.WriteLine("blab");
        }
    }
}
