//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Реализовать через функции.

double PromptDouble(string msg)
{
    System.Console.Write(msg);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

int PromptInt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int n)
{
    if (n <= 0)
    {
        System.Console.WriteLine("Вы ввели не натуральную степень");
        return false;
    }
    return true;
}

bool IsEven(int n)
{
    if (n % 2 == 0)
    {
        return true;
    }
    return false;
}

double DegreeRecursion(double x, int exp)
{
    while (exp > 1)
    {
        if (IsEven(exp))
        {
            double result = DegreeRecursion(x, exp / 2);
            result = result * result;
            return result;
        }
        else
        {
            double result = x * DegreeRecursion(x, exp - 1);
            return result;
        }
    }
}

double x = PromptDouble("Введите число: ");
int exp = PromptInt("Введите натуральную степень, в которую нужно возвести выше заданное число: ");
if (ValidateNumber(exp))
{
    double pro = DegreeRecursion(x, exp);
    Console.WriteLine($"Число {x} в степени {exp} равно {pro:F3}");
}