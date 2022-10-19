using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MaxContinuousValue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/// <summary>
			/// 陣列裡只會有 0, 3, 找出連續3的總和,例如
			/// {0,3,3,0,0,3,3,3} => 9
			/// {0,3,3,0,0,3,0,3,0,3} => 6
			/// {0,3,0,0} => 3
			/// </summary>
			 
			int sum=0;
			int maxSum=0;
			Console.WriteLine("請輸入一串由0或3組成的數字用\",\"隔開，只要連續3就相加，幫你找出最大和:");
			string input=Console.ReadLine();

			string 字串的數列 = "1";



			int[] array1 = { 0, 3, 3, 0, 0, 3, 0, 3, 0, 3 };
			for (int i = 0; i < array1.Length; i++)
			{
				if (array1[i] == 3)
				{
					sum += 3;
					if (sum >= maxSum)
					{
						maxSum = sum;
					}
				}
				else 
				{
					sum = 0;
				}
			}
			Console.WriteLine(maxSum);




		}
	}
}
