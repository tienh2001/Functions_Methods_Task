﻿using System;
					
public class Program
{
	 static void Main(string[] args)
	{
	int number, sum = 0;

	Console.WriteLine("Enter a number:");
	number = Convert.ToInt32(Console.ReadLine());

	while (number > 0)
	{
		sum += (number % 10);
		number /= 10;
	}
	Console.WriteLine("The sum of the number " + "is : " + sum);
	}
}



