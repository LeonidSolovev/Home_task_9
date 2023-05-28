// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int num1 = GetUserInput("Введите начальное значение: ", "Ошибка ввода!");
int num2 = GetUserInput("Введите конечное значение: ", "Ошибка ввода!");

if (num2>num1)
{
int res = FindSum(num1, num2);
Console.WriteLine(res);
}
else Console.WriteLine("Ошибка ввода !");

int FindSum(int number1, int number2)
{
    if (number2 == number1)
    {
        return number2;
    }
    else return number1+FindSum(number1+1, number2);
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