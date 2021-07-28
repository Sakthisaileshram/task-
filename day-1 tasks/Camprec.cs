using System;
public class CampRec
{
public static void Main()
{
int gpa,mark,test,hr;
Console.WriteLine("enter gpa");
gpa = Convert.ToInt32(Console.ReadLine());
if(gpa>7)
{
Console.WriteLine("enter apptitude score");
test = Convert.ToInt32(Console.ReadLine());
	if(test>7)
	{
	Console.WriteLine("enter technical score");
	mark = Convert.ToInt32(Console.ReadLine());
		if(mark>7)
		{
		Console.WriteLine("enter hr score");
		hr = Convert.ToInt32(Console.ReadLine());
			if(hr>7)
			{
			Console.WriteLine("selected");
			}
			else{
			Console.WriteLine("not selected");
			}
		}
		else
		{
		Console.WriteLine("try after 3 months");
		}
	}
	else
	{
	Console.WriteLine("try after 6 months");
	}
}
else
{
Console.WriteLine("not eligible");
}
}
}