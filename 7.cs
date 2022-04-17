using System;
					
public class Program
{
	 static void Main(string[] args)
	{
		int number, power;

		Console.WriteLine("Input base number: ");
		number = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Input the exponent: ");
		power = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("So, the number " + number + "^" + power + "=" + pow(number, power));
	}
	
		static int pow(int number, int power)
	{
		if (power == 0)
		return 1;
		return number * pow(number, --power);
	}
}



