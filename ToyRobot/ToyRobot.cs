using System;

namespace ToyRobotChallenge
{
    public enum Direction
    {
        NORTH,
        EAST,
        SOUTH,
        WEST
    }
    public class ToyRobot
    {
        private int X;
        private int Y;
        private Direction? Facing;
        private const int GridSize = 5;

        public void Place(int x, int y, Direction facing)
        {
            if (IsValidPosition(x, y))
            {
                X = x;
                Y = y;
                Facing = facing;
            }
        }

        public void Move()
        {
            if (Facing == null) return;

            int newX = X, newY = Y;

            switch (Facing)
            {
                case Direction.NORTH:
                    newY++;
                    break;
                case Direction.EAST:
                    newX++;
                    break;
                case Direction.SOUTH:
                    newY--;
                    break;
                case Direction.WEST:
                    newX--;
                    break;
            }

            if (IsValidPosition(newX, newY))
            {
                X = newX;
                Y = newY;
            }
        }

        public void Left()
        {
            if (Facing == null) return;


            if (Facing == Direction.NORTH)
                Facing = Direction.WEST;
            else if (Facing == Direction.SOUTH)
                Facing = Direction.EAST;
            else if (Facing == Direction.EAST)
                Facing = Direction.NORTH;
            else if (Facing == Direction.WEST)
                Facing = Direction.SOUTH;


        }

        public void Right()
        {
            if (Facing == null) return;


            if (Facing == Direction.NORTH)
                Facing = Direction.EAST;
            else if (Facing == Direction.SOUTH)
                Facing = Direction.WEST;
            else if (Facing == Direction.EAST)
                Facing = Direction.SOUTH;
            else if (Facing == Direction.WEST)
                Facing = Direction.NORTH;

        }

        public string Report()
        {
            if (Facing == null)
                return "Robot is not yet placed.";

            return $"{X},{Y},{Facing}";
        }

        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < GridSize && y >= 0 && y < GridSize;
        }
    }
}
