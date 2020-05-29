namespace Mazes
{
	public static class My_SnakeMazeTask
	{
        public static void Move(Robot robot, int mazeProp, Direction to)
        {
            for (int i = 1; i < mazeProp - 2; i++)
                robot.MoveTo(to);
        }
        public static void StepsDown(Robot robot)
        {
            int steps = 2;
            while(steps>0)
                {
                robot.MoveTo(Direction.Down);
                steps--;
                }
        }
        public static void MoveOut(Robot robot, int width, int height)
		{
            int povorot = 0;
            while (true)
            { 
                Move(robot, width, Direction.Right);
                StepsDown(robot);
                Move(robot, width, Direction.Left);
                povorot++;
                if (povorot == height / 4) break;
                StepsDown(robot);
            }
        }
	}
}