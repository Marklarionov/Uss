using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uss
{
    class Point
    {
        //добавление переменных для координат
        public int x;
        public int y;
        public char sym;

        public Point()
        {
        }
        //конструктор для определения координат
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        //конструктор для приравнивания координат змейке 
        public Point(Point p)
        {
            x=p.x;
            y=p.y; 
            sym = p.sym;
        }

        // метод для движения змейки по координатам X и Y
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        // метод для удаления хвоста змейки при движении
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}
