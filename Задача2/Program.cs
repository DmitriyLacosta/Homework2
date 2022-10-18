//робот считает программистов


Console.WriteLine("Программа правильно говорит количество программистов");
Console.WriteLine("введите количество программистов: ");
int a = int.Parse(Console.ReadLine()!);
int b = a;
if(a == 11 || a == 12 || a == 13 || a == 14 || a == 15 || a == 16 || a == 17 || a == 18 || a == 19 || a == 20)
{Console.WriteLine("в офисе " + a); Console.WriteLine("программистов");
return;
}

while (b > 10)
    {
        b = b % 10;
    }
if(b == 1)
{
Console.WriteLine("в офисе " + a); Console.WriteLine("программист");
return;
}
if(b == 2 || b == 3 || b == 4  && b != 5)
{
 Console.WriteLine("в офисе " + a); Console.WriteLine("программиста");
return;
}

if(b >= 5 || b == 0 || b == 6 || b == 7 || b == 8 || b == 9)
{
 Console.WriteLine("в офисе " + a); Console.WriteLine("программистов");
return;
}


