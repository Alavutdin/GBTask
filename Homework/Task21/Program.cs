using static System.Console;
Clear();
WriteLine("Введите координаты X первой точки:");
int x1 = int.Parse(ReadLine()!);
WriteLine("Введите координаты Y первой точки:");
int y1 = int.Parse(ReadLine()!);
WriteLine("Введите координаты Z первой точки:");
int z1 = int.Parse(ReadLine()!);
WriteLine("Введите координаты X второй точки:");
int x2 = int.Parse(ReadLine()!);
WriteLine("Введите координаты Y второй точки:");
int y2 = int.Parse(ReadLine()!);
WriteLine("Введите координаты Z второй точки:");
int z2 = int.Parse(ReadLine()!);

int numberA = x2 -x1;
int numberY = y2 - y1;
int numberZ = z2 - z1;

double lenght = Math.Sqrt(numberA * numberA + numberY * numberY + numberZ * numberZ);
WriteLine($"Длина отрезка составляет: {lenght:f2}");
