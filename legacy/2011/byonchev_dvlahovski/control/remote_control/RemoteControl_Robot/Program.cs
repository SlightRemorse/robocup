using System;
using System.IO.Ports;

namespace RemoteControl_Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort device = new SerialPort("COM5", 9600);

            device.Open();

            while (true)
            {
                int command = 0;

                try 
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.LeftArrow:
                        {
                            command = 24;
                            break;
                        }

                        case ConsoleKey.RightArrow:
                        {
                            command = 40;

                            break;
                        }

                        case ConsoleKey.UpArrow:
                        {
                            command = 56;

                            break;
                        }

                        case ConsoleKey.DownArrow:
                        {
                            command = 52;

                            break;
                        }

                        default:
                        {
                            command = 60;
                            break;

                        }
                    }
                }
                catch (Exception ex)
                {
                    break;
                }

                char c = (char)command;
                string toSend = new string(c, 1);

                device.Write(toSend);

            }

            device.Close();
        }
    }
}
