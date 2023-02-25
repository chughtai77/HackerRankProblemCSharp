using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camelCase
{
	 class Program
	{

		static void camelCase()
		{
			//oneTwoThree

			Console.Write("Enter String Value ");

			string str = Console.ReadLine();
			int len = str.Length;
			
			int ans = 1;

			for (int i = 0; i < len; i++)
			{
				if (str[i] >= 'A' && str[i] <= 'Z')
				{
					ans++;
				}
			}
			Console.WriteLine(ans);
		}

		static void Main(string[] args)
		{
			while (true) {
			
				camelCase();
			//	Console.ReadLine();
			
			}
		}
	}
}
