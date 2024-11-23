using System;
using System.Globalization;
namespace ToyRobotChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's go my robot.");
            Console.WriteLine("Please using below commands to control the robot.");
            Console.WriteLine("X and Y should be number from 0 to 4.");
            Console.WriteLine("F must be NORTH,SOUTH,WEST and EAST");
            Console.WriteLine("PLACE X,Y,F");
            Console.WriteLine("MOVE");
            Console.WriteLine("LEFT");
            Console.WriteLine("RIGHT");
            Console.WriteLine("REPORT");
            Console.WriteLine("CTRL C to stop the program.");
            ToyRobot robot = new ToyRobot();
            while (true)
            {
                String robotCommands = Console.ReadLine();
                if (robotCommands.Contains("PLACE"))
                {
                    string[] commands = robotCommands.Split(" ");
                    string[] commandParameters = commands[1].Split(",");
                    Direction directionParameter = (Direction)Enum.Parse(typeof(Direction), commandParameters[2]);
                    robot.Place(int.Parse(commandParameters[0]),
                         int.Parse(commandParameters[1]),
                        directionParameter
                         );
                } else if (robotCommands.Contains("MOVE"))
                {
                    robot.Move();
                } else if(robotCommands.Contains("LEFT"))
                {
                    robot.Left();
                } else if(robotCommands.Contains("RIGHT"))
                {
                    robot.Right();
                } else if(robotCommands.Contains("REPORT"))
                {
                    Console.WriteLine(robot.Report());
                }

            }
        }
    }
}
