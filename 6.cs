using System;
					
public class Program
{
	 static void Main(string[] args)
	{
	int num1, num2, temp;
	Console.WriteLine("Enter a number");
	num1 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter another number");
	num2 = Convert.ToInt32(Console.ReadLine());

	temp = num1;
	num1 = num2;
	num2 = temp;

	Console.WriteLine("Now the 1st number is: " + num1 + ", and the 2nd number is: " + num2);
	}
	
}