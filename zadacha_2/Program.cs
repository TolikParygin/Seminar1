// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"
Console.Clear();
Console.WriteLine("Введите число:");
int nomber = int.Parse(Console.ReadLine());
int count=-nomber;
if (nomber>=0)
    while(count<=nomber)
    {
        Console.Write(count + ", ");
        count++;
    }
else
while(count>=nomber)
{
Console.Write(nomber +", ");
nomber++;
}

