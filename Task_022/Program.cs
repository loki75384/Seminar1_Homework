// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int number = Promt("Введите чмсло N: ");
int i = 1;
SqrtOfNumb(i, number);

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

void SqrtOfNumb(int i, int number)
{
    while (i <= number)
    {
        Console.Write(i * i + " ");
        i++;
    }
    return;
}
