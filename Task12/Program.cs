// 12. Напишите программу, которая
// 1. будет принимать на вход два числа 
// 2. выводить, является ли первое число кратным второму.
// 3. Если первое число не кратно второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.Write("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = Remain (number1, number2);
string printLine = result == 0 ? " Кратно" : $" не кратно, остаток {result}";// тернарный оператор с result
Console.WriteLine(printLine);

int Remain(int number1, int number2)
{
    int res = number1 % number2;
    return res;
}

