// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Программа показывает 2-ю цифру трехзначного числа");
Console.WriteLine("введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);

void deleteSecond(int a)
{
    if (a > 99 && a < 1000)
    {
        int first = a / 100;
        int three = a % 10;

        int b = ((a - (first * 100 + three)) / 10);
        Console.WriteLine("вторая цифра введенного числа: " + b);

    }
    else
    {
        Console.WriteLine("некорректное число. Введите трехзначное число!");
    }
}
deleteSecond(a);
