using System;

class Program {
  public static void Main (string[] args) {
   Console.WriteLine("Введите значения координат точки x1");
    int x1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значения координат точки y1");
    int y1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значения координат точки z1");
    int z1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значения координат точки x2");
    int x2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значения координат точки y2");
    int y2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значения координат точки z2");
    int z2 = int.Parse(Console.ReadLine());

    double d = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));

    Console.WriteLine($"{d:f3}");
  }
}