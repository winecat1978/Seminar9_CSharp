// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии
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


int PowerA_B(int A, int B)
{
    if (B != 1)
    {
        A = PowerA_B(A,B-1)*A;
    }
    return A;
}

string messageN = "Введите первое положительное целое число.";
int A = GetNumber(messageN);
string messageM = "Введите второе положительное целое число.";
int B = GetNumber(messageM);

int result = PowerA_B(A,B);
Console.WriteLine($"{A} в степени {B} = {result}");