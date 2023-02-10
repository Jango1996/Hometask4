// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число, и программа посчитает сумму цифр в числе");
int a = Convert.ToInt32(Console.ReadLine());
int sum(int a)
{
int result = 0;
    while (a>10)
    {
    result += a % 10;
    a /= 10;
    }
    result += a;
    return result;
}

int result = sum(a);
Console.WriteLine($"{result}");


