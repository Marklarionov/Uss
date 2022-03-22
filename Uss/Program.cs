using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Uss
{
	class Program
	{
		static void Main(string[] args)
		{
			Score score = new Score();
			Params param = new Params();
			Sounds soundOS = new Sounds(param.GetResourceFolder());
			Sounds soundEat = new Sounds(param.GetResourceFolder());
			Sounds soundDead = new Sounds(param.GetResourceFolder());


			//вывод стен
			walls walls = new walls(80, 25);
			walls.Draw();

			//точки			
			Point p = new Point(4, 5, '-');
			Console.ForegroundColor = ConsoleColor.Cyan;
			snake snake = new snake(p, 4, Direction.RIGHT);
			snake.Draw();

			//создание еды
			FoodCreator foodCreator = new FoodCreator(80, 25, '@');
			Point food = foodCreator.CreateFood();
			food.Draw();

			// игровой процесс 
			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					soundDead.Dead();
					break;
				}
				if (snake.Eat(food))
				{
					score.Shet();
					soundEat.PlayEat();
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep(100);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			WriteGameOver();
			Console.ReadLine();
		}
		static void WriteGameOver()
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("============================", xOffset, yOffset++);
			WriteText("    G A M E    O V E R", xOffset + 1, yOffset++);
			WriteText("============================", xOffset, yOffset++);
		}
		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}
	}
}