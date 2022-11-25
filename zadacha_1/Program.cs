Console.Clear();
Console.WriteLine("Введите 2 числа ");
int nomberA = int.Parse(Console.ReadLine());
int nomberB = int.Parse(Console.ReadLine());

if(nomberA/nomberB==nomberB)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");    
}
