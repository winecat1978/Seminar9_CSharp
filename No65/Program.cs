// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
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

void RecursionM_N(int N, int M)
{
    if (N-M > 1)
    {
        RecursionM_N(N-1, M);
        Console.Write($"{N-1} ");
    }
    else Console.Write($" ");
}

string messageN = "Введите первое положительное целое число.";
int N = GetNumber(messageN);
string messageM = "Введите второе положительное целое число.";
int M = GetNumber(messageM);
RecursionM_N(N, M);