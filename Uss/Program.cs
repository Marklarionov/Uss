using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            // Отрисовка рамки
            HorizonatallLine upline = new HorizonatallLine(0, 78, 0, '+');
            HorizonatallLine downline = new HorizonatallLine(0, 78, 24, '+');
            Verticalline leftLine = new Verticalline(0, 24, 0, '+');
            Verticalline rightline = new Verticalline(0, 24, 78, '+');
            upline.Drow();
            downline.Drow();
            leftLine.Drow();
            rightline.Drow();

            //Отрисовка точек
            Point p = new Point(4, 5, '*') ;
            p.Draw();

            Console.ReadLine();
        }
    }
}
