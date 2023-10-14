// Напишите программу, которая на вход принимает трёхзначное число и на выходе показывает последнюю цифру этого числа

int ReadInt(string msg) // объявление функции
{
    System.Console.WriteLine(msg); // вывод на экран параметра msg функции
    string inputString = Console.ReadLine(); // считывает строку из консоли
    int number = int.Parse(inputString); // преобразует строку в число
    return number; // возврат значения
}

int inputNumber = ReadInt("Введите трехзначное число: "); // вызов функции
if (inputNumber > 99 & inputNumber < 1000)
{
    System.Console.WriteLine($"Последняя цифра {inputNumber % 10}");
}
else
{
    System.Console.WriteLine("Число не трехзначное!");
}