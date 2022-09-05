
void MaxMin (int arg1, int arg2) 
{
    int min = 0; int max = 0;
    if (arg2 > arg1)
    {
        max = arg2; min = arg1;
    }
    else if (arg1 > arg2)
    {
        max = arg1; min = arg2;
    }
    Console.WriteLine($" {max} - максимум, а {min} - минимум.");
}

Console.WriteLine("Введите первое число.");
int a = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine()); 

MaxMin(a,b);