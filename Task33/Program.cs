// Задача 33: 
// Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int [] array = CreateArrayRndInt(5, 1, 1000);
Console.Write("[");
PrintArray(array, ";");
Console.WriteLine("]");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindNumber(array, number) 
                   ? $"Массив содержит число {number}" 
                   : $"Массив не содержит число {number}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] arr, string sep = ",")
{
     for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

bool FindNumber (int [] newarr, int numb)
{
    for (int i = 0; i < newarr.Length; i++)
    {
        if (newarr[i] == number) return true;
     }
     return false;
}

