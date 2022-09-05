//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

void Max (int arg1) 
{
    if (arg1%2 == 0) {
        Console.WriteLine ($"{arg1} - чётное число");
    }
    else {
        Console.WriteLine ($"{arg1} - нечётное число");
    } 
}

Console.WriteLine("Введите число.");
int a = int.Parse(Console.ReadLine());

Max(a);