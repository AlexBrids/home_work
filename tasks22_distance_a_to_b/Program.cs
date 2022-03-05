// Найти расстояние между точками в пространстве 2D/3D

using static System.Console;
Clear();

int GetNumber()
{
    int randNumber = new Random().Next(-100, 100);
    return randNumber;
}

int numberX1 = GetNumber();
int numberY1 = GetNumber();

int numberX2 = GetNumber();
int numberY2 = GetNumber();

int numberZ1 = GetNumber();
int numberZ2 = GetNumber();

// Вариант 1 2В

void Distance2D(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    WriteLine($"Расстояние от точки a до точки b равно d 2D: {distance}");
}

Distance2D(numberX1, numberY1, numberX2, numberY2);

// Вариант 2 3D

void Distance3D(int x1, int y1, int x2, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    WriteLine($"Расстояние от точки a до точки b равно d 3D: {distance}");
}

Distance3D(numberX1, numberY1, numberX2, numberY2, numberZ1, numberZ2);