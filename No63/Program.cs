// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string ValueFromConsole = Console.ReadLine();
        if (int.TryParse(ValueFromConsole, out int num))
        {
            if (num > 0) return num;
            else
            {
                Console.WriteLine("Введите положительное число.");
            }
        }
        else
        {
            Console.WriteLine("Введите число.");
        }
    }
}

void Recursion(int N)
{
    if (N != 1) 
    {
        Recursion(N-1);
        Console.Write($" {N}");
    }
    else Console.Write($"{N}");
}

string message = "Введите положительное целое число.";
int N = GetNumber(message);
Recursion(N);
