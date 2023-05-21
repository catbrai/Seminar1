Console.WriteLine("Введите целое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.WriteLine($"Да, {numberA} является квадратом числа {numberB}");
}
else 
{
    Console.WriteLine($"Нет, {numberA} не является квадратом числа {numberB}");
};

