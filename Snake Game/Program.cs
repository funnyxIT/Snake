using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(80, 25);


            // Draw Lines
            HorizontalLine line = new HorizontalLine(0,78,0,'+');
            line.Drow();

            VerticalLine line2 = new VerticalLine(0,24,0, '+');
            line2.Drow();

            VerticalLine line3 = new VerticalLine(0, 24, 78, '+');
            line3.Drow();

            HorizontalLine line4 = new HorizontalLine(0, 78, 24, '+');
            line4.Drow();



            //Draw point
            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Drow();


            Console.ReadLine();

        }
        
    }
}
