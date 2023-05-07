
void Main()
{
    bool isWork = true;
    while (isWork)
    {
        Console.WriteLine("Enter command ");
        string command = Console.ReadLine();

        switch (command)
        {
            case "Task 1": Task1() ;
            break;
            case "Task 2": Task2() ;
            break;
            case "exit": isWork = false;
            break;
        }
    }
}
Main();

// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void Task1 ()
{  
    InitNumbers();
}

void InitNumbers()
{
    Console.WriteLine("Enter the numbers: ");
    int [] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

    PrintNumber(array);
    int pos = PositiveNumbers(array);

    Console.WriteLine($"Кличество чисел больше 0 = {pos}");
}

void PrintNumber(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

int PositiveNumbers(int [] array)
{
    int positive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            positive += 1;
        }    
    }
     return positive;    
}

// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем

void Task2()
{
    // Console.WriteLine("Введите b1: ");
    // int b1 = int.Parse(Console.ReadLine());
    // Console.WriteLine("Введите k1: ");
    // int k1 = int.Parse(Console.ReadLine());
    // Console.WriteLine("Введите b2: ");
    // int b2 = int.Parse(Console.ReadLine());
    // Console.WriteLine("Введите k2: ");
    // int k2 = int.Parse(Console.ReadLine());

    // Console.Write($"{b1} {k1} {b2} {k2}");
    // Console.WriteLine();
   FillPoint();
}


void FillPoint()
{
    Console.WriteLine("Введите b1: ");
    int b1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите k1: ");
    int k1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите b2: ");
    int b2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите k2: ");
    int k2 = int.Parse(Console.ReadLine());

    Console.Write($"{b1} {k1} {b2} {k2}");
    Console.WriteLine();   

    InitCoordinatesX_Y(b1, k1, b2, k2);
}

double InitCoordinatesX_Y(int b1, int k1, int b2, int k2)
{

    if (k1 - k2 != 0)
    {
        double x1 = b2 - b1;
        double x2 = k1 - k2;
        double x = Math.Round((x1 / x2), 2);
        double y = Math.Round((k1 * x + b1), 2);

        Console.Write($"Координаты точки пересечения - {x};{y}");
    }
    else
    {
        Console.WriteLine("Прямые параллельные и не пересекаются");
    }
    return b1;
    return k1;
    return b2;
    return k2;

}

