namespace Mazes
{
	public static class My_DiagonalMazeTask
    {
        
        public static void StepsTo(Robot robot,int steps,Direction direction)
        {
            while (steps > 0)
            {
                robot.MoveTo(direction);
                steps--;
            }
        }
        
        public static void MoveRight(Robot robot,int width,int height)
        {
            int stepsRight = (width - 2) / (height - 2);
            int stepsDown = 1;
            int path=0;
            while (true)
            {
                StepsTo( robot, stepsRight, Direction.Right);
                path++;
                if (path == ((width - 2) / stepsRight)) break;
                StepsTo( robot, stepsDown, Direction.Down);
            }
        }
        public static void MoveDown(Robot robot, int width,int height)
        {
            int stepsDown = (height - 2) / (width - 2);
            int stepsRight = 1;
            int path = 0;
            while (true)
            {
                StepsTo(robot, stepsDown,Direction.Down);
                path++;
                if (path == ((width - 2) / stepsRight)) break;
                StepsTo(robot, stepsRight, Direction.Right);
            }
        }

        public static void MoveOut(Robot robot, int width, int height)
		{ 
          if (width - height > 0) MoveRight(robot, width,height);
          else MoveDown(robot, width, height);
        }
	}
}