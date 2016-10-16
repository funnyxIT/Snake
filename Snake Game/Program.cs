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

            Point p1 = new Point(1,3,'*'); // create new point
            
            p1.Draw();   //Draw symbol


            Point p2 = new Point(4,5,'#');
           
            p2.Draw();   

            
            Console.ReadLine();

        }
        
    }
}
