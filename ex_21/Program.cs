//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите z2: ");
int z2 = int.Parse(Console.ReadLine());



double PointToPoint = Math.Round(Math.Sqrt((Math.Pow((x2-x1),2)) + (Math.Pow((y2-y1),2)) + (Math.Pow((z2-z1),2))));
Console.WriteLine($"Расстояние между двумя точками: {PointToPoint}");

