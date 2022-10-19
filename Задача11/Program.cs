// Задача 11 HARD - необязательная: Напишите программу, которая принимает на вход целое число любой разрядности число и удаляет вторую цифру слева направо этого
// числа.

Console.WriteLine("Программа удаляет 2-ю цифру заданного числа");
Console.WriteLine("введите положительное число: ");
int a = int.Parse(Console.ReadLine()!);

if (a > 9)
{
    void deleteSecond(int a)
    {
        int sum = 0;
        int numberPos = 1;
        while (a > 99)
        {
            int b = a % 10;
            sum = sum + b * numberPos;
            numberPos = numberPos * 10;
            a = a / 10;
        }
        a = a / 10;
        int result = a * numberPos + sum;
        Console.WriteLine("получившееся число: " + result);
    }
    deleteSecond(a);

}
else
    Console.WriteLine("второй цифры нет");

