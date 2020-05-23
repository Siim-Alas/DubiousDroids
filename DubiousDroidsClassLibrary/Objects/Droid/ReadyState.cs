using DubiousDroidsClassLibrary.IO;
using DubiousDroidsClassLibrary.Objects.Droid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Droid
{
    public class ReadyState : IDroidState
    {
        public void OnInputParsed(object source, InputParsedEventArgs args)
        {
            Console.WriteLine(string.Join('-', args.Instructions));
        }
    }
}
