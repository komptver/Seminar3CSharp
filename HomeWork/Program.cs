/* Task2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double DinstanceAB(double xa, double ya, double za, double xb, double yb, double zb)
{
double length  = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2)); //Расстояние» d = √ [(x2-x1)2+ (y2-y1)2],
return Math.Round(length, 2);
}

Console.WriteLine("Input an x-coordinate of point a: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an y-coordinate of point a: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an z-coordinate of point a: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an x-coordinate of point b: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an y-coordinate of point b: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an z-coordinate of point b: ");
double zb = Convert.ToDouble(Console.ReadLine());
double distance = DinstanceAB(xa,ya,za,xb,yb,zb);
Console.WriteLine($"distance between three points a and b is {distance}");

*/
/* Task3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int number)
{
    int x = 1;
    int stepen = 3;
    while(x <= number)
    {
        Console.Write($"{Math.Pow(x, stepen)} ");
        x++;
    }
}     
  Console.Write("Input an integer number ");
  int number = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("The series of squares of number");
  Cube(number);

  */