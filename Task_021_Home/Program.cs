// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int xa = Promt("Введите координату xA: ");
int xb = Promt("Введите координату xB: ");
int ya = Promt("Введите координату yA: ");
int yb = Promt("Введите координату yB: ");
int za = Promt("Введите координату zA: ");
int zb = Promt("Введите координату zB: ");

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double AB = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));

Console.WriteLine(AB);


