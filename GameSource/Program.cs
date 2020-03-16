using System;

namespace GameSource
{
	class Program
	{
		static void Main(string[] args)
		{
			using(var game = new GameCore())
			{
				game.Run();
			}
		}
	}
}
