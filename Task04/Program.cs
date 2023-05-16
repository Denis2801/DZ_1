//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третие число: ");
int c = int.Parse(Console.ReadLine());

int max = 0;

//if (a > b)
//{
//    if (a > c)
//    {
//        max = a;
//        Console.WriteLine($"max = {max}");
//    }
//    else
//    {
//    max = c;
//    Console.WriteLine($"max = {max}"); 
//    }
//    
//}
//else
//{
//    if (b > c)
//{
//    max = b;
//    Console.WriteLine($"max = {max}");
//}
//else
//{
//max = c;
//Console.WriteLine($"max = {max}");
//}
//}

if (a > b & a > c)
{
    max = a;
    Console.WriteLine($"max = {max}");
}
else 
{
    if (b > c)
    {
    max = b;
    Console.WriteLine($"max = {max}");  
    }
    else
    {
    max = c;
    Console.WriteLine($"max = {max}");
    }
}
