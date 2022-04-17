using System;
					
public class Calculator
{
	 static void Main(string[] args)
	{
		AddTwoNums(15, 16);
	}
	static void AddTwoNums(int num1, int num2) {
		int ans = num1 + num2; 	
			Console.WriteLine("The sum of two numbers is: " + ans);
		
	}
}