//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
//Реализовать через функции.

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int NumberModule(int n)
{
    if (n < 0)
    {
        n = n * (-1);
        return n;
    }
    return n;
}

int SumDigits(int x)
{
    int result = 0;
    while (x > 0)
    {
        result = result + x % 10;
        x = x / 10;
    }
    return result;
}

int x = Prompt("Введите число: ");
x = NumberModule(x);
int result = SumDigits(x);
Console.WriteLine($"Сумма цифр в числе {x} равно {result}");

