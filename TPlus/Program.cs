/*
Дополнительная задача (задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов, 
которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.

[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево

[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо
*/

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int [] array = GetArray(size,-10,11);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine("Произведите сдвиг элементов исходного массива на одну позицию вправо: ");
ShiftElementsToRight(array);
PrintArray(array);
Console.WriteLine("Вернёмся к исходному массиву: ");
ShiftElementsToLeft(array);
PrintArray(array);
Console.WriteLine("Произведите сдвиг элементов исходного массива на одну позицию влево: ");
ShiftElementsToLeft(array);
PrintArray(array);
static void ShiftElementsToRight(int[] array)
{
    int last = array[array.Length - 1];

    for (int i = array.Length - 2; i >= 0; i--)
    {
        array[i + 1] = array[i];
    }
    array[0] = last;
}

static void ShiftElementsToLeft(int[] array)
{
    int first = array[0];
for (int i = 0; i < array.Length - 1; i++)
{
array[i] = array[i+1];
}
array[array.Length - 1] = first;
}
int [] GetArray(int size, int min, int max){
    int[] result = new int[size];

    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(min, max + 1);
    }
return result;
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


