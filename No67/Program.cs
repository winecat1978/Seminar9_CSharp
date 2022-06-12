// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
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

// int GetLength (int N)
// {
//     int length = 0;
//     do
//     {
//         length++;
//         N=N/10;
//     }
//     while(N%10 != 0);
//     return length;
// }

int Summa (int N)
{
 int sum = 0;
 int ostatok = 0;
 while (N > 9)
 {
     ostatok = N%10;
     N=N/10;
     sum+=ostatok;
 }
 sum +=N;
 return sum;
}


string message = "Введите положительное целое число.";
int N = GetNumber(message);
// int Length = GetLength(N);
// Console.WriteLine(Length);
// int sum = 0; 
int result = Summa(N);
Console.WriteLine($"{result}");

