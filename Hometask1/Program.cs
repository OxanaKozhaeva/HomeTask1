/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
int max=a, min=b;
if(b>max)
{
    max=b;
    min=a;
}
Console.Write("max=");
Console.WriteLine(max);
Console.Write("min=");
Console.WriteLine(min);
