// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int x = Promt("Введите координату x: ");
int y = Promt("Введите координату y: ");
FindQuarter(x, y);

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void FindQuarter(int X, int Y)
{
    if (X > 0 && Y > 0)
    {
        Console.WriteLine("1 четверть");
    }
    else if (X < 0 && Y > 0)
    {
        Console.WriteLine("2 четверть");
    }
    else if (X < 0 && Y < 0)
    {
        Console.WriteLine("3 четверть");
    }
    else if (X > 0 && Y < 0)
    {
        Console.WriteLine("4 четверть");
    }
    else
    {
        Console.WriteLine("Ошибка");
    }
}