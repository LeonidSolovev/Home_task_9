// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int num1 = GetUserInput("Введите первое значение: ", "Ошибка ввода!");
int num2 = GetUserInput("Введите второе значение: ", "Ошибка ввода!");

int res = FindAkkerman(num1, num2);
Console.WriteLine($" m = {num1}; n = {num2} -> A(m,n) = {res}");

int FindAkkerman(int firstNum, int secondNum)
{
    if (firstNum == 0)
    return secondNum + 1;
  else
    if ((firstNum != 0) && (secondNum == 0))
      return FindAkkerman(firstNum - 1, 1);
    else
      return FindAkkerman(firstNum - 1, FindAkkerman(firstNum, secondNum - 1));
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