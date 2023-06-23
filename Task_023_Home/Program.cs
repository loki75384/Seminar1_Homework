// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3-> 1, 8, 27
// 5-> 1, 8, 27, 64, 125

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
        Console.Write(i * i * i + " ");
        i++;
    }
    return;
}
