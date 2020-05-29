namespace Mazes
{
	public static class My_EmptyMazeTask
	{   public static void Move(Robot robot,int mazeProp,Direction to)
        {
            for (int i = 1; i < mazeProp - 2; i++)
                robot.MoveTo(to);
        }
        public static void MoveOut(Robot robot, int width, int height)
		{
            Move(robot, width,Direction.Right);
            Move(robot, height,Direction.Down);
        }
	}
}