// 9. Напишите программу, которая 
// 1)выводит случайное число из отрезка [10, 99] 
// 2) показывает наибольшую цифру числа.
// 
//78 -> 8   :78 / 10 = 7.8 - целочиленное деление на 10(остаток отбрасывается, берется только 7)
// 12-> 2   :12 % 10 = 2 - остаток деления на 10
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");// отрезок 10-(99+1) последнее число не включено в дипазон
int firstDigit = number / 10;
int secondDigit = number % 10;
// if (firstDigit > secondDigit)                                          1 вариант решения
//     Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else
//     Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;    2 вариант решения через тернарный оператор
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

// int maxDigit1 = MaxDigit(76);                                    метод работает на разных значениях
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit1}");
// int maxDigit2 = MaxDigit(56);
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit2}");

int MaxDigit (int num)// MaxDigit - название метода, num = number (копия этой переменной)
{                               // тело метода, где выполнется алгоритм
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; 
    return maxDigit; //выход из алгоритма, вывод значения

    // return maxDigit= firstDigit > secondDigit ? firstDigit : secondDigit; можно и так
}