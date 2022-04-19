Console.Write ("введите число :");
int n = Convert.ToInt32(Console.ReadLine());
if(n>99)
{
System.Console.WriteLine(n.ToString()[2]);
}
else
{
   System.Console.WriteLine("у числа не хватает цифры");
}