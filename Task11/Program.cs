// 11. Напишите программу, 
// которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");

// int firstDigit = number / 100;
// int firstDigit2 = firstDigit * 10;
// int secondDigit = number % 10;
// int doubleDigit = firstDigit2+secondDigit;

// Console.WriteLine(doubleDigit);

int deletSecondDigit = DeleteSecondDigit(number);
Console.WriteLine($"Число без второй цифры {deletSecondDigit}");

int DeleteSecondDigit (int num)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    return firstDigit * 10 + secondDigit;
}