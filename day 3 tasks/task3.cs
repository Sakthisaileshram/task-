using System;
public class containsmethods
{
public void enterData(String M,String P)
{
Console.WriteLine("valid email and password");
}
public void enterData(String M,int P)
{
Console.WriteLine("membership id and pin matches");
}
public void enterData(int M,int P)
{
Console.WriteLine("valid mobile and pin ");
}
}
public class front
{
public static void Main()
{
Console.WriteLine("enter mail id");
String mail=Console.ReadLine();
Console.WriteLine("enter password");
String pword=Console.ReadLine();
containsmethods obj1= new containsmethods();
	obj1.enterData(mail,pword);
Console.WriteLine("enter membership id");
String memid=Console.ReadLine();
Console.WriteLine("enter pin");
int pin=Convert.ToInt32(Console.ReadLine());
containsmethods obj2= new containsmethods();
	obj2.enterData(memid,pin);
Console.WriteLine("enter mobile number");
int no=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("pin");
int piin=Convert.ToInt32(Console.ReadLine());
containsmethods obj3= new containsmethods();
	obj3.enterData(no,piin);
}
}