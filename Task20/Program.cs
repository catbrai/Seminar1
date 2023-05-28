// double d = Math.Sqrt(5);
// double num = 5.099874453;
// double dRound = Math.Round(num, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(dRound);

// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату Х1");
int x1Coor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y1");
int y1Coor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х2");
int x2Coor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y2");
int y2Coor = Convert.ToInt32(Console.ReadLine());


double dRound = Distance(x1Coor, y1Coor, x2Coor, y2Coor);
double result = Math.Round(dRound, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками -> {result}");

double Distance(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return distance;
}

// int EnterCoordinate(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// double Distance(int x1, int y1, int x2, int y2)
// {
//     return Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)); // Math.Pow(x2-x1, 2) квадрат 
// }


// int xOfA = EnterCoordinate("Enter x for A");
// int yOfA = EnterCoordinate("Enter y for A");
// int xOfB = EnterCoordinate("Enter x for B");
// int yOfB = EnterCoordinate("Enter y for B");

// double result = Distance(xOfA, yOfA, xOfB, yOfB );

// System.Console.WriteLine("Distance between dots: ");
// System.Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));