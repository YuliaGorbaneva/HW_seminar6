
void Toch()
{

    Console.WriteLine("Введите b1: ");
 int b1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите k1: ");
    int k1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите b2: ");
    int b2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите k2: ");
int k2 = int.Parse(Console.ReadLine());
      
    if (k1 - k2 != 0)
    {
        double x1 = b2 - b1;
        double x2 = k1 - k2;
        double x = x1 / x2;

        double y = k1 * x + b1;

        Console.Write($"{b1} {k1} {b2} {k2}");
        Console.WriteLine();
        Console.Write($"{x};{y}");
    }
    else
    {
        Console.WriteLine("Прямые параллельные и не пересекаются");
    }
}

Toch();