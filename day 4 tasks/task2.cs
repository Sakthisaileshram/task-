using System;
interface isilver
{
void silver();
}
interface igold
{
void gold();
}
interface iplatinum
{
void platinum ();
}
class Member:isilver,igold,iplatinum
{
public void silver() 
{
Console.WriteLine("3 days accomodation at resort");
}
public void gold() 
{
Console.WriteLine("5 days accomodation at resort & 2 dinners on the house");
}
public void platinum() 
{
Console.WriteLine("7 days accomodation at resort & 5 dinners on the house");
}
}
class Front
{
public static void Main()
{
Console.WriteLine("enter your membership");
String m=Console.ReadLine();
Member obj=new Member();
switch(m)
{
case "silver" : obj.silver() ;
break;
case "gold" :obj.gold() ;
break;
case "platinum" :obj.platinum();
break;
default :Console.WriteLine(" not match");
break;
}
}
}