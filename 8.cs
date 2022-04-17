using System;
					
public class Program
{
	 static void Main(string[] args)
	{
		Console.WriteLine("Input number of Fibonacci series:");
		int x = Convert.ToInt32(Console.ReadLine());

		int next = 0;
		int previous = 0;
		for (int i = 0; i <= x; i++)
		{
			Console.WriteLine(next);
			if (next == 0)
			{
				next = 1;
			}
			else 
			{
				int temp = next;
				next = next + previous;
				previous = temp;

			}
		}

	}
}



