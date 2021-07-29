using System;
class nameXage
{
public static void Main()
{
int age;
Console.WriteLine("Enter name");
String name = Console.ReadLine();
Console.WriteLine("Enter age");
age = Convert.ToInt32(Console.ReadLine());
for(int i=0;i<age;i++)
{
Console.WriteLine(name);
}
}
}