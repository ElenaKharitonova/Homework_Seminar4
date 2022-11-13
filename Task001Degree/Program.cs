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

bool ValidateNumber(double n)
{
    if (n <= 0)
    {
        System.Console.WriteLine("Вы ввели не натуральную степень");
        return false;
    }
    return true;
}
double Degree(double x,int n)
{
    int count = 1;
    double result = x;
       while (count <= n-1)
    {
        result = result * x;
        count++;
    }
return result;
}
double x = PromptDouble("Введите число: ");
int exp = PromptInt("Введите натуральную степень, в которую нужно возвести выше заданное число: ");
if (ValidateNumber(exp))
{
double pro = Degree(x,exp);

Console.WriteLine($"Число {x} в степени {exp} равно {pro:F3}");
}