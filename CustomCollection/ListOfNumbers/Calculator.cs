using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection.ListOfNumbers
{
	public static class Calculator
	{
		public static List<int> GenerateList(int size)
		{
			Random random = new Random();

			List<int> numbers = new List<int>();			
			numbers.Add(2);

			for (int i = 1; i < size; i++)
			{
				numbers.Add(random.Next(0, 10));
			}

			return numbers;
		}

		public static double CalculateSum(List<int> numbers)
		{
			double result = 0;

			for (int i = 0; i < numbers.Count; i++)
			{
				result += numbers[i] / (i + 1);
			}

			return Math.Floor(result);
		}
	}
}
