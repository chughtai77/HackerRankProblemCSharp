using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuzzBuzz
{
	internal class Program
	{
		public static void fizzBuzz(int n)
		{
			for (int i = 1; i <= n; i++)
			{

				if (i % 3 == 0 && i % 5 == 0)
				{

					Console.WriteLine("fizzbuzz");
				}
				else if (i % 3 == 0)
				{
					Console.WriteLine("fizz");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("buzz");
				}
				else
				{
					//return Convert.ToString(i) ;
					Console.WriteLine(i);
				}

			}
		}




		static void Main(string[] args)
			{

			fizzBuzz(15);

			Console.ReadLine();
			}
		}
	}