Console.WriteLine("Введите координаты первой точки x, y, z");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки x, y, z");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

Double findlenghe(int xa, int ya, int za, int xb, int yb, int zb)
{

Double a = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));

return a;
}
Double result=findlenghe( x1, y2, z1, x2, y1, z2);
Console.Write("Длина отрезка =");
Console.WriteLine(result);
