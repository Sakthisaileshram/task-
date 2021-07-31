using System;
public class Base
{
public virtual void calculateTax(int s)
{
int VAT;
VAT= s*20/100; 
Console.WriteLine("The Vat is : "+VAT);
}
}
public class derived : Base
{
public override void calculateTax (int s)
{
int GST;
GST= s*12/100; 
Console.WriteLine("The GST is : "+GST);
}
public static void Main()
{
Console.WriteLine("enter salary");
int salary=Convert.ToInt32(Console.ReadLine());
Base obj1=new Base();
obj1.calculateTax(salary);
derived obj2=new derived();
obj2.calculateTax(salary);
}
}