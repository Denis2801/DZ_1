//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое натуральное число: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int y = int.Parse(Console.ReadLine());

int max = 0;

if (x > y)
{
    max = x;
    Console.WriteLine($"{max} Больше");
}
else
{
    max = y;
    Console.WriteLine($"{max} Больше");
}