using System; 
public class products
{
public static void Main()
{
String [][] product = new String[3][];//declaration of outer array (or) no of arrays
product[0] = new String[5]{"Biscuits:","borbon","crackers","jimjam","milkb ikies"};
product[1] = new String[6]{"Chocolates:","diary milk","munch","kitkat","kinderjoy","toblerone"};
product[2] = new String[8]{"Drinks:","pepsi","fanta","miranda","coco-cola","thumbsup","maaza","frooti"};
for(int i =0;i<product.Length;i++)
{
	for(int j=0;j<product[i].Length;j++)
	Console.WriteLine(product[i][j]);
Console.WriteLine();
}
}
}