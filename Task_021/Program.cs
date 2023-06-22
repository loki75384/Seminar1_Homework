// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


int xa = Promt("Введите координату xA: ");
int xb = Promt("Введите координату xB: ");
int ya = Promt("Введите координату yA: ");
int yb = Promt("Введите координату yB: ");


int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double AB = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));

Console.WriteLine(AB);