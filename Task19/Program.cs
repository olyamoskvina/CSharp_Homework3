// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();

if (int.TryParse(number, out int num))
{
    string N = Convert.ToString(Math.Abs(num));
    if (N.Length == 5)
    {
        if (N[0] == N[4] && N[1] == N[3])
        {
            Console.Write("Введенное число палиндром");
        }
        else Console.Write("Введенное не является палиндромом");
    }
    else Console.Write("Вы ввели не пятизначное число");
}
else Console.Write("Вы ввели не число. Попробуйте снова.");

