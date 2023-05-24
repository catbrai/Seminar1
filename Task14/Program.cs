// 14. Напишите программу,
//  1. которая принимает на вход число 
//  2.и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool DevidedByTwoNumbers( int num, int num1, int num2)// devided - разделенный
{
    return num % num1 == 0 && num % num2 == 0;
// if((num % num1 == 0) && (num % num2 == 0)) return true;
// else return false;
} 

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
bool myresult = DevidedByTwoNumbers(number, 7, 23);
Console. WriteLine(myresult ?"да": "нет");

