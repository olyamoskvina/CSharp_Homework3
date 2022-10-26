// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");

// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// if (number > 9999 && number < 100000) 
// {
//     int FirstNumber = number / 10000;
//     int SecondNumber = number / 1000 % 10;
//     int FourthNumber = number / 10 % 10;
//     int FifthNumber = number % 10;

//     if (FirstNumber == FifthNumber && SecondNumber == FourthNumber)
//     {
//         Console.WriteLine($"{number} - палиндром");
//     }
//     else Console.WriteLine($"{number} не является палиндромом");
// }
// else Console.WriteLine("Вы ввели не пятизначное число. Введите число еще раз.");



void palindrome(int number)
{
    if (number > 9999 && number < 100000)
    {
        int FirstNumber = number / 10000;
        int SecondNumber = number / 1000 % 10;
        int FourthNumber = number / 10 % 10;
        int FifthNumber = number % 10;

        if (FirstNumber == FifthNumber && SecondNumber == FourthNumber)
        {
            Console.WriteLine($"{number} - палиндром");
        }
        else Console.WriteLine($"{number} не является палиндромом");
    }
    else Console.WriteLine("Вы ввели не пятизначное число. Введите число еще раз.");
}

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
palindrome(number);
