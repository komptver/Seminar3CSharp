/* Task1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//в качестве аргумента берем два числа

int FindQuadrant(double x, double y) //Описание метода (ввели название и указали переменные)
{
    if (x > 0 && y > 0 ) return 1;   // если х и у положительные, то в качестве результата можем вернуть первую четверть
    if (x < 0 && y > 0 ) return 2; 
    if (x < 0 && y < 0 ) return 3; 
    if (x > 0 && y < 0 ) return 4;
    return 0;                        // но значения не должны быть равны 0. 0 не может принимать номер четверти.           
}                                    // если бы сделали else 0, то данная команда относилась только к последней строке,
                                     // тогда бы пришлось else 0 писать после каждого if 
// обращаемся к пользователю:
Console.WriteLine("Input an x-coordinate");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an y-coordinate");
double y = Convert.ToDouble(Console.ReadLine());        

int quadNum = FindQuadrant(x,y);   // объявляем переменную номер четверти (int quadNum)

Console.WriteLine($"The point A (x {x}, y {y}) is on the {quadNum} quadrunt"); //тчка с координатами находится в .... четверти



/* Task2. Напишите программу, которая по заданному номеру четверти, 
          показывает диапазон возможных координат точек в этой четверти (x и y). 

          // Тип будет void, на вход будет int

void Four(int quarter) //Название Четыре
{
    if(quarter == 1)Console.WriteLine("x > 0, y > 0"); // первая четверь
    else if(quarter == 2)Console.WriteLine("x < 0, y > 0"); //вторая
    else if(quarter == 3)Console.WriteLine("x < 0, y < 0"); //третья
    else if(quarter == 4)Console.WriteLine("x > 0, y < 0"); // четвертая
    else Console.WriteLine("No such quarter");
}
Console.WriteLine("Input a number quadrant");
int quadrant = Convert.ToInt32(Console.ReadLine());
Four(quadrant);
 */

 /* Task3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.  

       // Тип будет double и на вход double

double DinstanceAB(double xa, double ya, double xb, double yb)
{
double length  = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya,2)); //Расстояние» d = √ [(x2-x1)2+ (y2-y1)2],
return Math.Round(length, 2);
}

Console.WriteLine("Input an x-coordinate of point a: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an y-coordinate of point a: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an x-coordinate of point b: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an y-coordinate of point b: ");
double yb = Convert.ToDouble(Console.ReadLine());

double distance = DinstanceAB(xa,xb,ya,yb);
Console.WriteLine($"distance between points a and b is {distance}");
*/
/*  Task4. Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.  
       // Тип будет void и на вход int   

void Squares (int number)
{
    int counter = 1;
    while(counter <= number)
    {
        Console.Write($"{Math.Pow(counter, 2)} ");
        counter++;
    }
}     
  Console.Write("Input an integer number ");
  int number = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("The series of squares of number");
  Squares(number);
  */