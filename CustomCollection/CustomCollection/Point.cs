using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection
{
	public struct Point
	{
		public int X { get; set; }
		public int Y { get; set; }


		public Point(int x, int y) : this()
		{
			X = x;
			Y = y;
		}

		public override string ToString()
		{
			return String.Format("({0},{1})", X, Y);
		}
	}

	public class PointComparer : IComparer<Point>
	{

		public int Compare(Point x, Point y)
		{
			var result = Math.Sqrt((x.X ^ 2) + (x.Y ^ 2));
			return 0;
		}
	}

}
