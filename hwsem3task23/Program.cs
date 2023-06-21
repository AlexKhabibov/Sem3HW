// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeN(int numberN)
{
    int current = 1;
    while (current <= numberN)
    {
        double result = Math.Pow(current, 3);
        Console.Write($"{result:f0}, ");
        current++;
    }
    Console.WriteLine("\b\b.");
}
void CubeNnegative(int numberN)
{
    int current = 1;
    while (current >= numberN)
    {
        double result = Math.Pow(current, 3);
        Console.Write($"{result:f0}, ");
        current--;
    }
    Console.WriteLine("\b\b.");
}

Console.Write("Input number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 0)
    CubeN(userNumber);
else 
    CubeNnegative(userNumber);