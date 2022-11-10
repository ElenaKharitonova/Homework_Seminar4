//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Реализовать через функции.

int Prompt(string message)
{
    System.Console.Write(message);
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
int x = Prompt("Введите число: ");
int n = Prompt("Введите натуральную степень, в которую нужно возвести выше заданное число: ");
if (ValidateNumber(n))
{
double pro = Degree(x,n);

Console.WriteLine($"Число {x} в степени {n} равно {pro}");
}