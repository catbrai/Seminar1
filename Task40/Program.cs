// Задача 40: Напишите программу, которая 
// принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int Start()
{
    Console.Write("Введите целоe положительное число, соответствующее длине стороны треугольника: ");
    return Convert.ToInt32(Console.ReadLine());
}

bool Treangle(int numA, int numB, int numC)
{
    return ((numA < numB + numC) && (numB < numA + numC) && (numC < numA + numB));
    }

int numberA = Start();
int numberB = Start();
int numberC = Start();
if (numberA <= 0 || numberB <= 0 || numberC <= 0)
{
    Console.WriteLine("Вы ввели некорректное число");
    return;
}

Console.WriteLine(Treangle (numberA, numberB, numberC)
                ? $" Да, треугольник со сторонами такой длины может существовать."
                : $" Нет, треугольник со сторонами такой длины не может существовать.");
