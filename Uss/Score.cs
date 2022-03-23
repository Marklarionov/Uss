using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uss
{
    public class Score
    {
        int score = 0;
        public Score()
        {

        }
        public void Shet()
        {
            score += 1;
            Console.SetCursorPosition(70, 20);
            Console.WriteLine($"Score: {score}");

        }
    }
}
