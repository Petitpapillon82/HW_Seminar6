/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
 
/*
решение уравнения, находим x: k1*x + b1 = k2x + b2, (k1 – k2) * x = b2 – b1, x = (b2 – b1) / (k1 – k2), 
при этом y = k * x1 + b1 (или y = k2 * x + b2)
исходя из формул уравнения прямой (a1*x + b1*y = c1 и a2*x + b2*y = c2), 
система имеет единственное решение, если a1 * b2 != a2 * b1. 
Если же a1 * b2 = a2 * b1, то прямые параллельны и не пересекаются. В нашем случае b1 соответствует k1, a1 = 1
*/
Console.WriteLine("Найдите точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1; 

x = Math.Round(x, 1);
y = Math.Round(y, 1);
 
if (b1 == b2 && k1 == k2) 
  {
    Console.WriteLine("Прямые совпадают");
  }
  else if (b1 ==b2 && k1 != k2)  
  {
    Console.WriteLine("Прямые параллельны");
  }
  else 
  {
Console.WriteLine($"Точка пересечения прямых ({x}, {y})");
  }
/*
Можно не показывать, какие именно это прямые (параллельные, совпадающие) тогда:
if(k1==k2) Console.WriteLine("Заданные прямые не пересекаются"); 
else
Console.WriteLine($"две прямые пересекаются в точке с координатами X: {x}, Y: {y}");*/
