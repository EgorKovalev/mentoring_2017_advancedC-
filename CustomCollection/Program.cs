
using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
			IList<Point> points = new MyCollection<Point>(5);

			points.Add(new Point(10, 20));
			points.Add(new Point(0, 5));
			points.Add(new Point(30, 50));

			points = points.OrderBy(x => x, new PointComparer()).ToList();

			foreach(var item in points)
			{
				Console.WriteLine(item.ToString());
			}			 
        }
    }
}
