using System;
public class Base
{
public void Add(int n, int m)
{
Console.WriteLine("the sum is "+(n+m));

}
public void Sub(int n, int m)
{

Console.WriteLine("the difference is "+(n-m));

}
}

public class Derived:Base
{
public void Mul(int n, int m)
{
Console.WriteLine("the product "+(n*m));

}
public void Div(int n, int m)
{
Console.WriteLine("remainder is  "+(n/m));

}
public static void Main()
{
Console.WriteLine("enter the numbers");
int a =Convert.ToInt32(Console.ReadLine());
int b =Convert.ToInt32(Console.ReadLine());
//Base obj = new Base();
Derived obj2 = new Derived();
obj2.Add(a,b);
obj2.Sub(a,b);
obj2.Div(a,b);
obj2.Mul(a,b);
}
}

