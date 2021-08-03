using System;
public class one
{
String name;
int age;
public void members()
{
Console.WriteLine(" enter name");
name=Console.ReadLine();
Console.WriteLine(" enter age");
age=Convert.ToInt32(Console.ReadLine());
}
public void members(String n,int a)
{
name=n;
age=a;
}
public void Display()
{
Console.WriteLine(" NAME IS :"+name);
Console.WriteLine(" NAME IS :"+age);

}
public static void Main()
{
one obj= new one();
one obj1= new one();
obj.members();
obj1.members("sakthi",21);
obj.Display();
obj1.Display();
}
}