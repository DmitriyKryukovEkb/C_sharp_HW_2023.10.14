// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

int ReadInt(string msg) // объявление функции
{
    System.Console.WriteLine(msg); // вывод на экран параметра msg функции
    string inputString = Console.ReadLine(); // считывает строку из консоли
    int number = int.Parse(inputString); // преобразует строку в число
    return number; // возврат значения
}

int inputNumber = ReadInt("Введите число: "); // вызов функции
string answer;
string[] days = {
    "Понедельник",
    "Вторник",
    "Среда", 
    "Четверг", 
    "Пятница", 
    "Суббота", 
    "Воскресенье"
};
if (inputNumber > 0 & inputNumber < 8)
{
    if (inputNumber > 5)
    {
        answer = "выходной";
    }
    else
    {
        answer = "рабочий день";
    }
    System.Console.WriteLine($"{days[inputNumber - 1]} - это {answer}");
}
else
{
    System.Console.WriteLine("Не является днем недели");
}