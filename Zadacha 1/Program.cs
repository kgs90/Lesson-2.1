System.Console.WriteLine("Введите трехзначное число -");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number /10 % 10);
Console.Write($"Вторая цифра - {(number /10 % 10)}");
