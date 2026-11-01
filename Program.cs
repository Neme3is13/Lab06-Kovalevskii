// задани 1.1
// int s = 0;
// for (int i = 1; i <= 10; i++) {
//     System.Console.WriteLine(i);
// }
//заданий 1.2
// int s = 0;
// for (int i = 1; i <= 50; i++)
// {
//     if (i % 2 == 0)
//     {
//         System.Console.WriteLine(i);
//     }
// }
//задание 2
// int sum = 0;
// int sum2 = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         sum += i;
//     }
//     if (i % 7 == 0)
//     {
//         sum2++;
//     }
// }
// System.Console.WriteLine(sum);
// System.Console.WriteLine(sum2);
//задание 3
// int number = Convert.ToInt32(Console.ReadLine());
// int total = 0;
// int otr = 0;
// int pol = 0;

// while (number != 0)
// {
//     total += number;
//     number = Convert.ToInt32(Console.ReadLine());
//     if (number >= 0)
//     {
//         pol++;
//     }
//     else
//     {
//         otr++;
//     }
// }
// System.Console.WriteLine(total);
// System.Console.WriteLine($"положительных чисел - {pol}");
// System.Console.WriteLine($"отрицательных чисел - {otr}");
//задание 4
// Задание 4
// bool flag = false;

// for (int i = 1; i <= 3; i++)
// {
//     Console.WriteLine($"Попытка {i}. Введите пароль: ");
//     string password = Console.ReadLine();
//     if (password == "qwerty")
//     {
//         Console.WriteLine("Доступ разрешён");
//         flag = true;
//         break;
//     }
// }
// if (flag == false)
// {
//     Console.WriteLine("Доступ заблокирован");
// }
// задание 5
// Console.Write("Введите цифру (1-9): ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= 10; i++)
// {
//     System.Console.WriteLine($"{n} x {i} = {n*i}");
// }
// задание 6
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 == 0)
//     {
//         continue;
//     }
//     if (i % 10 == 0 && i > 20)
//     {
//         break; 
//     }
//     Console.WriteLine(i);
// }
// Итоговая задача
// int secret = 42;
// bool flag = false;
// for (int i = 1; i <= 5; i++)
// {
//     Console.Write($"Попытка {i}. Введите число: ");
//     int guess = Convert.ToInt32(Console.ReadLine());
//     if (guess == secret)
//     {
//         Console.WriteLine($"Победа! Попыток: {i}");
//         flag = true;
//         break;
//     }
//     else if (guess < secret)
//     {
//         Console.WriteLine("Больше");
//     }
//     else
//     {
//         Console.WriteLine("Меньше");
//     }
// }
// if (flag == false)
// {
//     Console.WriteLine($"Вы проиграли, число было {secret}");
// }
// доп задача
using System.Diagnostics.CodeAnalysis;

Console.Write("введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int total = 0;
while (x > 0)
{
    sum += x % 10;
    x /=10;
    total++;
}
System.Console.WriteLine(sum);
System.Console.WriteLine(total);