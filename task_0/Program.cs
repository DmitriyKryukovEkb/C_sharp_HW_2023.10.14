// Напишите программу, которая на вход принимает трёхзначное число и на выходе показывает последнюю цифру этого числа
System.Console.WriteLine("Введите трехзначное число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
if (inputNumber > 99 & inputNumber < 1000)
{
    System.Console.WriteLine($"Последняя цифра {inputNumber % 10}");
}
else
{
    System.Console.WriteLine("Число не трехзначное!");
}