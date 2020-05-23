﻿using DubiousDroidsClassLibrary.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Droid.Interfaces
{
    public interface IDroidState
    {
        int[] Position { get; }
        void ReceiveCommand(InputParsedEventArgs args);
    }
}
