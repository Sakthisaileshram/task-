using System;
public class marklist
{
public static void Main()
{
int total=0,percentage=0;
int [] marks= new int[5];
Console.WriteLine("enter marks scored in subjects");
for (int i=0;i<5;i++)
{
marks[i] =Convert.ToInt32(Console.ReadLine());
}
for (int i=0;i<5;i++)
{
total=marks[i]+marks[i+1];
}
percentage=total*100/500;
Console.WriteLine("the total and percentage are "+ total+percentage);
}
}
