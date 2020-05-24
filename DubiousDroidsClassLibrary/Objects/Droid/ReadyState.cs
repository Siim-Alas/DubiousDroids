using DubiousDroidsClassLibrary.IO;
using DubiousDroidsClassLibrary.Objects.Droid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace DubiousDroidsClassLibrary.Objects.Droid
{
    public class ReadyState : IDroidState
    {
        public ReadyState()
        {
            Position = new int[] { 0, 0 };
            DirectionVector = new int[] { 1, 0 };
        }
        public ReadyState(int[] position, int[] directionVector)
        {
            Position = position;
            DirectionVector = directionVector;
        }

        public event DroidReportStatusEventHandler DroidReportedStatus;

        public int[] Position { get; private set; }
        public int[] DirectionVector { get; private set; }

        public void ReceiveCommand(InputParsedEventArgs args)
        {
            switch (args.Instructions)
            {
                case InputParsedEventArgs.InstructionsEnum.peek:
                    DroidReportStatusEventArgs.DirectionEnum direction;

                    if (DirectionVector[0] == 0)
                    {
                        direction = (DirectionVector[1] == 1) ? DroidReportStatusEventArgs.DirectionEnum.S : DroidReportStatusEventArgs.DirectionEnum.N;
                    }
                    else
                    {
                        direction = (DirectionVector[0] == 1) ? DroidReportStatusEventArgs.DirectionEnum.E : DroidReportStatusEventArgs.DirectionEnum.W;
                    }

                    DroidReportedStatus(this, new DroidReportStatusEventArgs(args.CommandTarget, Position, direction));
                    break;
                case InputParsedEventArgs.InstructionsEnum.turn:
                    if (args.Argument == "right")
                    {
                        // x cos(pi/2) - y sin(pi/2) = 0 - y
                        // x sin(pi/2) + y cos(pi/2) = x + 0
                        int previousX = DirectionVector[0];
                        DirectionVector[0] = -1 * DirectionVector[1];
                        DirectionVector[1] = previousX;
                    }
                    else if (args.Argument == "left")
                    {
                        // x cos(-pi/2) - y sin(-pi/2) = 0 - (-y)
                        // x sin(-pi/2) + y cos(-pi/2) = -x + 0
                        int previousX = DirectionVector[0];
                        DirectionVector[0] = DirectionVector[1];
                        DirectionVector[1] = -1 * previousX;
                    }
                    break;
                case InputParsedEventArgs.InstructionsEnum.move:
                    int amount;
                    try
                    {
                        amount = Convert.ToInt32(args.Argument);
                    }
                    catch
                    {
                        amount = 1;
                    }
                    Position[0] += amount * DirectionVector[0];
                    Position[1] += amount * DirectionVector[1];
                    break;
                default:
                    break;
            }
        }
    }
}
