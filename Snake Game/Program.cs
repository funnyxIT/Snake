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

            Point p3 = new Point(8, 7, '$');


            Point p4 = new Point(2, 9, '&');

            List<Point> pList = new List<Point>(); // Add point list 
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);


            List<char> cList = new List<char>();
            cList.Add('#');
            cList.Add('#');
            cList.Add('#');
            cList.Add('#');

            



            Console.ReadLine();

        }
        
    }
}
