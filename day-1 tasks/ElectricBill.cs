using System;
public class bill
{
public static void Main()
{
int unit,total=0, sum;
Console.WriteLine("enter the units");
unit = Convert.ToInt32(Console.ReadLine());
if(unit<=200)
{
Console.WriteLine(unit*2);
total=unit*2;
}
if(unit>200 && unit<=350)
{
total=200*2;
unit=unit-200;
sum= unit*3;
Console.WriteLine(total+sum);
}
if(unit>350 && unit<=500)
{
total=200*2+150*3;
unit=unit-350;
sum= unit*5;
Console.WriteLine(total+sum);
}
if(unit>500)
{
total=200*2+150*3+350*5;
unit=unit-700;
sum= unit*7;
Console.WriteLine(total+sum);
}
}
}