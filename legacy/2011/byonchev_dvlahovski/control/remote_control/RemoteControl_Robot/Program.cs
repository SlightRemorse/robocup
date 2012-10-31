using System;
using System.IO.Ports;

namespace RemoteControl_Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort device = new SerialPort("COM6", 9600);

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
							command = 1;
							break;
						}

                        case ConsoleKey.RightArrow:
						{
							command = 2;

							break;
						}

                        case ConsoleKey.UpArrow:
						{
							command = 3;

							break;
						}

                        case ConsoleKey.DownArrow:
						{
							command = 4;

							break;
						}

                        default: // Any key pressed -> Stop
						{
							command = 0;
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
