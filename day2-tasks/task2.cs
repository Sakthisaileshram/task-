using System;
class multi 
{
public static void Main()
{
int N,sum;
Console.WriteLine("Enter the number");
N=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("the multiplication is ");
	for(int i=1;i<20;i++)
	{
	sum = N*i;
	Console.WriteLine(sum);
	}
}
}