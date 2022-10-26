// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число ");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int count = 1; count < N; count++)
// {
//      Console.Write($"{Math.Pow(count,3)}, ");
// }
// Console.WriteLine($"{Math.Pow(N, 3)}, ");


void cube(int N)
{
    if (N > 0)
    {
        int count = 1;
        while (count <= N)
        {
            Console.Write(Math.Pow(count, 3) + " ");
            count++;
        }
    }
    else Console.WriteLine($" число {N} не соответствует условию ввода. Введите число больше 1. ");
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
cube(N);