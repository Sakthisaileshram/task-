using System;
public class patientinfo
{
public static void Main()
{
Console.WriteLine("enter the name of the patient");
String name = Console.ReadLine();
Console.WriteLine("enter the age of the patient");
int age=Convert.ToInt32(Console.ReadLine());
if(age>16)
{
Console.WriteLine("adult case");
}
else
{Console.WriteLine("pediatric cases");}
} 
}