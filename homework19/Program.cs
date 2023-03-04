Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number;
int result = 0;
if (number>= 10000 && number <= 99999)
{
while (number > 0)
{
    result *= 10;
    result += number % 10;
    number /= 10;
}
    if (result == number2)
    Console.WriteLine("Число является палиндромом");

else Console.WriteLine("Число не является палиндромом");
}

else
Console.WriteLine("Число не является пятизначным");