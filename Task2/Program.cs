/* Задача 2.Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями
y = k1 * x + b1
y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

/* Решение системы урвнений
y = k1 * x + b1
y = k2 * x + b2;

y-y = k1 * x + b1-(k2 * x + b2)
0 = k1 *x + b1 - k2*x -b2
0 = (k1-k2)* x +b1 -b2
x = (b2-b1)/(k1-k2)
y = k2*(b2-b1)+b2
Формула Крамера.
k1*x-y+b1=0
k2*x-y+b2=0
x= -(c1*b2-c2*b1)/(a1*b2-a2*b1)
y= -(a1*c2-a2*c1)/(a1*b2-a2*b1)
a1= k1;
a2= k2;
b1=-1;
b2=-1;
c1=b1;
c2=b2;
*/

int Prompt(string message) //Ввод с приглашением.
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}


double b11 = Prompt("Ввведите b1? ->");
double b22 = Prompt("Ввведите b2? ->");
double k1 = Prompt("Ввведите k1? ->");
double k2 = Prompt("Ввведите k2? ->");


//double x = (b22 - b11) / (k1 - k2);   // частное решение 
//double y = k2 * ((b22 - b11) / (k1 - k2)) + b22;

double a1 = k1;
double a2 = k2;
double b1 = -1;
double b2 = -1;
double c1 = b11;
double c2 = b22;

if (a1 * b1 - a2 * b2 != 0)
{
    double x = -(c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1); // Решение по формуле Крамера.
    double y = -(a1 * c2 - a2 * c1) / (a1 * b2 - a2 * b1);
    System.Console.WriteLine($"Координаты точки пересечения [{x};{y}]");
}
else System.Console.WriteLine("Прямые параллельны или совпадают.");


