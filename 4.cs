using System;
					
public class Program
{
	 static void Main(string[] args)
	{
	int[] numbers = new int[5];

	numbers[0] = 5;
	numbers[1] = 7;
	numbers[2] = 3;
	numbers[3] = 2;
	numbers[4] = 9;
	
	int sum = 0;
	foreach (var i in numbers)
	{
		sum += i;
	}
	Console.WriteLine("The sum of the elements of the array is " + sum);
	}
	
}