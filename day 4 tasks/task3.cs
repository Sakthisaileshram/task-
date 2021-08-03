using System;
class Empdet
{
public String name;
public int id;
public String gen;
public int sal;
public int yoe;
public String dept;
public Empdet(string n,int i,string g,string d,int s,int ex)
{
name= n;
id = i;
gen =g;
dept=d;
sal = s;
yoe = ex;
}

class bonus:Empdet
{
public bonus(string n,int i,string g,string d,int s,int ex)
{
Console.WriteLine($"name :{n}");
Console.WriteLine($"id :{i}");
Console.WriteLine($"gender :{g}");
Console.WriteLine($"gender :{d}");
Console.WriteLine($"salary :{s}");
Console.WriteLine($"year of exp :{ex}");
switch(d)
{
case "sales and marketing" : Console.WriteLine("the total salary is :"+((sal*10/100)+sal));
break;
case "production" : Console.WriteLine("the total salary is :"+((sal*20/100)+sal));
break;
}
}
public static void Main()
{
Console.WriteLine("enter name ");
String ame=Console.ReadLine();
Console.WriteLine("enter id ");
int ed =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter gender");
String ggen=Console.ReadLine();
Console.WriteLine("enter salary");
int ssal=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter years of experience");
int yyoe=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter dept");
String deept=Console.ReadLine();
Empdet obj= new Empdet(ame,ed,ggen,deept,ssal,yyoe);
bonus ob1= new bonus(ame,ed,ggen,deept,ssal,yyoe);
}
}
}
