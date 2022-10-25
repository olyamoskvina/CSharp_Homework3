// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetDistanceFromCoordinates(int AX, int AY, int AZ, int BX, int BY, int BZ)
{
    double result = Math.Sqrt((Math.Pow((BX - AX), 2) + Math.Pow((BY - AY), 2) + Math.Pow((BZ - AZ), 2)));
    result = Math.Round(result, 2);
    return result;
}
Console.WriteLine("Введите координату AX");
int AX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату AY");
int AY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату AZ");
int AZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату BX");
int BX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату BY");
int BY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату BZ");
int BZ = Convert.ToInt32(Console.ReadLine());

double distance = GetDistanceFromCoordinates(AX, AY, AZ, BX, BY, BZ);
Console.WriteLine($"Расстояние между точками = {distance}");
