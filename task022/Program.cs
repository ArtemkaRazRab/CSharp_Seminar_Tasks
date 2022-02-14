// 22. Найти расстояние между точками в пространстве 2D/3D

double Distance2D(int xa, int ya, int xb, int yb)
{
    return Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2));
}
Console.WriteLine(Distance2D(6, 6, 4, 4));

double Distance3D(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2));
}
Console.WriteLine(Distance3D(6, 6, 4, 4, 7, 7));
