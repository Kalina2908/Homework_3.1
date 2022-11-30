/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int number = 1;
int count = 0;
while (count<N)
{
    int res = number%2;
    if (res==0)
    {
        Console.Write($"{number}, ");
    }
    number++;
    count++;
}