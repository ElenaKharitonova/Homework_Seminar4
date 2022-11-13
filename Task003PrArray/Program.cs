// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, 
// “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)
int PromptInt(string msg)
{
     System.Console.Write(msg);
     int number = Convert.ToInt32(Console.ReadLine());
     return number;
}

int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max+1);
    }
    return tempArray;
}

void PrintArray(int[] array)
{
    System.Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine();
}

int size = PromptInt("Введите количество элементов массива:  ");
int min = PromptInt("Введите минимальное значение элементов массива:  ");
int max = PromptInt("Введите максимальное значение элементов массива:  ");
int[] array = CreateArray(size, min, max);
System.Console.WriteLine("Массив длиной {size}, заполненный случайными числами от {min} до {max}:   ");
PrintArray(array);