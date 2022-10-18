// Задача 11 HARD - необязательная: Напишите программу, которая принимает на вход целое число любой разрядности число и удаляет вторую цифру слева направо этого
// числа.

Console.WriteLine("Программа удаляет 2-ю цифру заданного числа");
Console.WriteLine("введите положительное число: ");
int a = int.Parse(Console.ReadLine()!);
//int count = 1;
//int b = a;
if (a > 9)
{
    while (a > 1000)
    {
        a = a / 10;
        //count = count + 1;
    }
    int one = a / 100;
    int two = a % 10;
    //int result = a - (count * 10);
    Console.WriteLine("получившееся число: "+ one + two);

}
else
    Console.WriteLine("второй цифры нет");

