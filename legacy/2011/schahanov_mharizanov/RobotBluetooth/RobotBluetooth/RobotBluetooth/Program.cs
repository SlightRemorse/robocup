using System;
using System.IO.Ports;

namespace RemoteControl_Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            int Calibration = 0;

            Console.WriteLine("Set COM port (ex COM10): ");
            String comPort = Console.ReadLine();

            Console.WriteLine("Set speed (100 - 255): ");

            int SPEED = int.Parse(Console.ReadLine());



            SerialPort device = new SerialPort(comPort, 9600);

            device.Open();
            device.Write("c");

            while (true)
            {
                int command = 0;

                try
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.LeftArrow:
                            {
                                command = 20070;
                                break;
                            }

                        case ConsoleKey.RightArrow:
                            {
                                command = 21070;

                                break;
                            }

                        case ConsoleKey.UpArrow:
                            {
                                command = 11000 + SPEED + Calibration;

                                break;
                            }

                        case ConsoleKey.DownArrow:
                            {
                                command = 30000;

                                break;
                            }

                        case ConsoleKey.Spacebar:
                            {
                                command = 10000 + SPEED;
                                break;
                            }

                        default:
                            {
                                command = 30000;
                                break;

                            }
                    }
                }
                catch (Exception ex)
                {
                    break;
                }

                //char c = (char)command;
                //string toSend = new string(c, 1);

                device.Write(command.ToString());

            }

            device.Close();
        }
    }
}
