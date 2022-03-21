using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uss
{
	class Figure
	{
		protected List<Point> pList;

		//метод для отрисовки точек
		public void Draw()
		{
			foreach (Point p in pList)
			{

				p.Draw();
			}
		}

		//общий метод для касания точек
		internal bool IsHit(Figure figure)
		{
			foreach (var p in pList)
			{
				if (figure.IsHit(p))

					return true;
			}
			return false;
		}

		//приватный метод для касания точек
		private bool IsHit(Point point)
		{
			foreach (var p in pList)
			{
				if (p.IsHit(point))
					return true;
			}
			return false;
		}
	}
}
