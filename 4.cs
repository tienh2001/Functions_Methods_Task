using System;
					
public class Program
{
	 static void Main(string[] args)
	{
		Console.WriteLine("Pleae input a string");
		string input = Console.ReadLine();
	int count = 0;
	foreach (char item in input)
	{
		if (item == ' ')
		{
			count++; 
		}
	}
		Console.WriteLine(input + " Contains " + count + " spaces");

	}
	
}