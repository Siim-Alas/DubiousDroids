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
        public ReadyState()
        {
            Position = new int[] { 0, 0 };
            Angle = 0;
        }
        public ReadyState(int[] position, int angle)
        {
            Position = position;
            Angle = angle;
        }

        public int[] Position { get; private set; }
        public int Angle { get; private set; }

        public void ReceiveCommand(InputParsedEventArgs args)
        {
            switch (args.Instructions)
            {
                case InputParsedEventArgs.InstructionsEnum.peek:
                    Console.WriteLine($"Angle = {Angle}; Position = {string.Join(", ", Position)}");
                    break;
                case InputParsedEventArgs.InstructionsEnum.turn:
                    if (args.Argument == "right")
                    {
                        Angle += 1;
                    }
                    else if (args.Argument == "left")
                    {
                        Angle -= 1;
                    }
                    break;
                case InputParsedEventArgs.InstructionsEnum.move:

                    if (Angle % 4 >= 0)
                    {
                        if (Angle % 2 == 0)
                        {
                            if (Angle % 4 == 0)
                            {
                                Console.WriteLine("North");
                            }
                            else
                            {
                                Console.WriteLine("South");
                            }
                        }
                        else
                        {
                            if (Angle % 4 == 1)
                            {
                                Console.WriteLine("East");
                            }
                            else
                            {
                                Console.WriteLine("West");
                            }
                        }
                    }
                    else
                    {
                        if (Angle % 2 == 0)
                        {
                            Console.WriteLine("South");
                        }
                        else
                        {
                            if (Angle % 4 == -3)
                            {
                                Console.WriteLine("East");
                            }
                            else
                            {
                                Console.WriteLine("West");
                            }
                        }
                    }

                    break;
                default:
                    break;
            }
        }
    }
}
