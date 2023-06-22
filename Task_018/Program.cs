// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

int numberQuarter = Promt("Введите номер четверти: ");
FindCord(numberQuarter);

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void FindCord(int numberQuarter)
{
    if (numberQuarter == 1)
    {
        Console.WriteLine("X > 0, Y > 0");
    }
    else if (numberQuarter == 2)
    {
        Console.WriteLine("X < 0, Y > 0");
    }
    else if (numberQuarter == 3)
    {
        Console.WriteLine("X < 0, Y < 0");
    }
    else if (numberQuarter == 4)
    {
        Console.WriteLine("X > 0, Y < 0");
    }
    else
    {
        Console.WriteLine("Ошибка");
    }
}
