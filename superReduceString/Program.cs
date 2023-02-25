using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superReduceString
{
	internal class Program
	{
		public static string superReducedString(string s)
		{

			var stack = new Stack<char>();
			foreach (var i in s)
			{
				if (stack.Count > 0 && stack.Peek() == i)
				{
					stack.Pop();
				}
				else
				{
					stack.Push(i);
				}

			}
			if (stack.Count > 0)
			{
				return new string(stack.Reverse().ToArray());
			}
			else
			{
				return "Empty string";
			}

		}


		static void Main(string[] args)
		{

			//-------------------second try-----------------

			//Console.WriteLine("Enter string ");
			//String s = Console.ReadLine();

			//bool reduced = false;

			//do
			//{
			//	reduced = false;

			//	for (int i = 0; i < s.Length - 1;) //length 5-1=4    aabbb
			//	{
			//		if (s[i] == s[i + 1])           //s[0] == s[1] -> a==a
			//		{
			//			s = s.Substring(0, i) + s.Substring(i + 2);
			//			//  (0,0)+(0,2)
			//			//  (0,1)+(1,2)

			//			reduced = true;
			//		}
			//		else
			//			++i;
			//	}
			//} while (reduced == true);

			//if (s.Length == 0)
			//	Console.Out.WriteLine("Empty String");
			//else
			//	Console.Out.WriteLine(s);

			Console.WriteLine(superReducedString("aaabccddd")); // Output: "abd"
			Console.WriteLine(superReducedString("baab")); // Output: "Empty String"


			Console.Read();
		}
	}

}
	
