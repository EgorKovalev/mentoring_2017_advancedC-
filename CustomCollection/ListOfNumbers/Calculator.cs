using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection.ListOfNumbers
{
	public static class Calculator
	{
		// (https://habrahabr.ru/post/133037/)
		// (http://stackoverflow.com/questions/1042902/most-elegant-way-to-generate-prime-numbers)
		public static List<int> GenerateList(int size)
		{
			List<int> primes = new List<int>();
			primes.Add(2);
			int nextPrime = 3;
			
			while (primes.Count < size)
			{
				int sqrt = (int)Math.Sqrt(nextPrime);
				bool isPrime = true;
				for (int i = 0; (int)primes[i] <= sqrt; i++)
				{
					if (nextPrime % primes[i] == 0)
					{
						isPrime = false;
						break;
					}
				}
				if (isPrime)
				{
					primes.Add(nextPrime);
					Console.WriteLine("Added: " + nextPrime);
				}
				nextPrime += 2;
			}
			return primes;
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
