using System;
using System.Linq;
using System.Collections.Generic;
using CustomCollection.ListOfNumbers;
using CustomCollection.CompareObjects;

namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
			//Task1 - custom collection
			IList<Point> points = new MyCollection<Point>(5);

			points.Add(new Point(10, 20));
			points.Add(new Point(0, 5));
			points.Add(new Point(30, 50));

			points = points.OrderBy(x => x, new PointComparer()).ToList();

			//Task2 - a list of simple number
			int sizeArray = 0;

			Console.WriteLine("Enter size array");

			string input = Console.ReadLine();
			while (!int.TryParse(input, out sizeArray) || sizeArray < 1)
			{
				Console.WriteLine("Enter correct value");
				input = Console.ReadLine();
			}

			Calculator calculator = new Calculator();
			double calculatedResult = calculator.CalculateSum(calculator.GenerateList(sizeArray));
			
			Console.WriteLine("\nResult: " + calculatedResult);
			Console.ReadLine();

			//Task3 - comparing objects (https://msdn.microsoft.com/ru-ru/library/ms173147(v=vs.80).aspx)
			var person1 = new Person("Alex", "Ivanov");
			var person2 = new Person("Alex", "Ivanov");
			Console.WriteLine(person1.Equals(person2));
			Console.WriteLine(person1 == person2);

			var person3 = new Person("Alex", "Ivanov");
			var person4 = new Person("Alex", "NoIvanov");
			Console.WriteLine(person3.Equals(person4));
			Console.WriteLine(person3 != person4);
		}
    }
}
