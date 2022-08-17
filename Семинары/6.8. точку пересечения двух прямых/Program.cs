// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
//y = k1 *x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =9 -> (-0,5; -0,5)

// double k1 = 5;
// double k2 = 9;
// double b1 = 2;
// double b2 = 4;
// double x=(b2-b1)/(k1-k2);
// double y1 =  k1 *x + b1;
// double y2 =  k2 *x + b2;
// Console.WriteLine(x);
// Console.WriteLine(y1);
// Console.WriteLine(y2);
double k1 = 5;
double k2 = 9;
double b1 = 2;
double b2 = 4;

double FunctionX (double m, double r, double o,double l)
{
   double Ox = (m-r)/(o-l);
   return Ox;
}
double FunctionY (double Ox, double k, double b)
{
   double Oy = k*Ox + b;
return Oy;
}
void Print(double y)
{
 Console.Write(y+" ");
}
double x = FunctionX(b2,b1,k1,k2);
Print(x);
double y=FunctionY(x,k1,b1);
Print(y);


