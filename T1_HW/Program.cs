/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите число элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[m];
for (int i = 0; i < m; i++)
{
    Console.WriteLine("Введите число №{0}:    ", i + 1);
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Полученный массив: ");
Console.Write("[");
for (int i = 0; i < m; i++)
{
    Console.Write(" " + myArray[i] + " ");
}
Console.WriteLine("]");
int count = 0;
for (int i = 0; i < m; i++)
    if (myArray[i] > 0)
        count++;
Console.WriteLine($"В массиве чисел больше 0 : {count}");