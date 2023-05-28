//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int num = GetUserInput("Введите целое число N: ", "Ошибка ввода!");

int counter = 1;

if (counter < num)
{
    string res = PrintNumbers(counter, num);
    Console.WriteLine($"N = {num} -> {res}");
}
else Console.WriteLine("Ошибка ввода !");


string PrintNumbers(int index, int number)
{
    if (index == number)
    {
        return number.ToString();
    }
    else return number + " " + PrintNumbers(index, number - 1);
}
static int GetUserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);
    }
}