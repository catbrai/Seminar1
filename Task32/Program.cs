// Задача 32: Напишите
// программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void PrintArray(int[]arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

void ChangedSign (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
      arr[i] = arr[i] * (-1);// arr[i] *= -1
    }
}

int[] array = CreateArrayRndInt(5 ,-9, 9);
Console.Write("[");
PrintArray(array, ";");
Console.WriteLine("]");

ChangedSign(array);
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");

