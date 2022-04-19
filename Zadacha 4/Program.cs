System.Console.WriteLine("введите число дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <  6 && number >= 1)
{
    System.Console.WriteLine("рабочий день");
}
else if(number == 6 || number == 7) 
{
System.Console.WriteLine("выходной");
}
else 
{
    System.Console.WriteLine("неверный запрос.");
}