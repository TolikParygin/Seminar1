// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine());
int N3=N%10;
Console.WriteLine(N3);