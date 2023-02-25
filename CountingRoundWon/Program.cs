using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingRoundWon
{
	internal class Program
	{
		public static int playgame(int[] score) {

			int countplayer1 = 0;
			int countplayer2 = 0;

			foreach (int s in score) 
			{
				if (s == 1) { 
					countplayer1++;
				}else if (s == 2) {
					countplayer2++;		
				}
			
			}
			if (countplayer1 > countplayer2)
			{
				Console.Write("Player 1 has high record : ");
				return countplayer1;
			}
			else if (countplayer2 > countplayer1)
			{
				Console.Write("Player 2 has high record : ");
				return countplayer2;
			}
			else {

				Console.Write("Both players has same record : ");
				return countplayer1;
			}


		}


		//public static int CountRoundsWon(int[] scorecard)
		//{
		//	int countPlayer1 = 0;
		//	int countPlayer2 = 0;

		//	foreach (int score in scorecard)
		//	{
		//		if (score == 1)
		//		{
		//			countPlayer1++;
		//		}
		//		else if (score == 2)
		//		{
		//			countPlayer2++;
		//		}
		//	}

		//	if (countPlayer1 > countPlayer2)
		//	{
		//		return countPlayer1;
		//	}
		//	else if (countPlayer2 > countPlayer1)
		//	{
		//		return countPlayer2;
		//	}
		//	else
		//	{
		//		return countPlayer1; // or countPlayer2, since they are equal
		//	}
		//}


		static void Main(string[] args)
		{

			int[] score1 = { 1, 2, 2, 2, 1 };
			int[] score2 = { 1, 1, 2, 2 };
			int[] score3 = { 1, 2, 1, 2 };

			Console.WriteLine(playgame(score1));
			Console.WriteLine(playgame(score2));
			Console.WriteLine(playgame(score3));


			Console.Read();
























			//int[] scorecard1 = { 1, 2, 2, 1, 1 };
			//int[] scorecard2 = { 1, 2, 1, 2, 2, 2, 1 };
			//int[] scorecard3 = { 1, 2, 1, 2 };

			//Console.WriteLine("player 1 "+CountRoundsWon(scorecard1)); // Output: 3
			//Console.WriteLine("player 2" + CountRoundsWon(scorecard2)); // Output: 4
			//Console.WriteLine("player 3" + CountRoundsWon(scorecard3)); // Output: 2

			//Console.Read();


		}
	}
}
