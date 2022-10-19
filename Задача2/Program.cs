//Задача 2 необязательная. Робот считает программистов


Console.WriteLine("Программа правильно говорит количество программистов");
Console.WriteLine("введите количество программистов: ");
int a = int.Parse(Console.ReadLine()!);
int b = a;
void Person(int a)
{
    if (a > 9 && a < 20)
    {
        Console.WriteLine("в офисе " + a); Console.WriteLine("программистов");
    }
    else
        while (b >= 20 || b < 10)
        {
            b = b % 10;
        
        if (b == 1)
        {
        Console.WriteLine("в офисе " + a); Console.WriteLine("программист");
        break;
        }
        if (b == 2 || b == 3 || b == 4 && b != 5)
        {
        Console.WriteLine("в офисе " + a); Console.WriteLine("программиста");
        break;
        }
        if (b == 0 || b >= 5 ||  b <= 9 || b != 1)
        {
        Console.WriteLine("в офисе " + a); Console.WriteLine("программистов");
        break;
        }
        }

 }
 Person(a);


