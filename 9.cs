using System;
					
public class Program
{
	 static void Main(string[] args)
	{
		Console.WriteLine("Enter a number:");
		int num = Convert.ToInt32(Console.ReadLine());
		int k = 0;
	for (int i = 1; i <= num; i++)
	{
		if (num % i == 0)
		{
			k++;
		}
	}	
	if (k == 2)
	{
		Console.WriteLine(" is a prime number");
	}
	else
	{
		Console.WriteLine(" is not a prime number");
	}
	}
}



