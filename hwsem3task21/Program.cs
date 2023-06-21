// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double TripleSpaceAB(int xA, int xB, int yA, int yB, int zA, int zB)
{
    double TripleSpace = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
    return (TripleSpace);
}

Console.WriteLine("Input X coord of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coord of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coord of A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X coord of B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coord of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coord of B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());


double dist = TripleSpaceAB(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
Console.WriteLine($"Distance between A({xCoordA},{yCoordA},{zCoordA}) and B({xCoordB},{yCoordB},{zCoordB}) is {dist:f3}");