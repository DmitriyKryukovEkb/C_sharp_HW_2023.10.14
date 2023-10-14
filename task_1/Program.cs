// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int ReadInt(string msg) // объявление функции
{
    System.Console.WriteLine(msg); // вывод на экран параметра msg функции
    string inputString = Console.ReadLine(); // считывает строку из консоли
    int number = int.Parse(inputString); // преобразует строку в число
    return number; // возврат значения
}

int inputNumber = ReadInt("Введите число: "); // вызов функции
if (inputNumber > 99)
{
    int i = 1;
    while (inputNumber / i > 999)
    {
        i *= 10;
    }
    System.Console.WriteLine($"Третья цифра {inputNumber /i % 10}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}