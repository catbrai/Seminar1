// 11. Напишите программу, 
// которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");

int firstDigit = number / 100;
int secondDigit = number % 10;

Console.WriteLine($"{firstDigit}{secondDigit}");

int doubleDigit = DoubleDigit(number);
Console.WriteLine($"Двузначное число от случайного трехзначного -> {doubleDigit}");

int DoubleDigit (int num)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    string doubleDigit = firstDigit + secondDigit; 
    return doubleDigit; 
}