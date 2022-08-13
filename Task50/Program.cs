/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном массиве, и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
2, 3 -> такой элемент есть и равен 4
5, 5 -> такой элемент отсутствует
*/
Console.WriteLine("Введите колличество строк и столбцов через запятую без пробелов.");
int[] myArray = Array.ConvertAll<string, int>(Console.ReadLine().Split(','), elem =>
{ return System.Convert.ToInt32(elem); });

Console.WriteLine();
Console.WriteLine("Загадайте случайное число");
int NumRendom = Convert.ToInt32(Console.ReadLine());
int m = myArray[0];
int n = myArray[1];
int[,] array = new int[m, n];
int count = 0;


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");

        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);

        }
    }
}

FillArray(array);
Console.WriteLine("Выводим массив случайных чисел");
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {

        if (array[i, j] == NumRendom)
        {
            Console.WriteLine("Такое число есть в массиве, его индексы " + i + ", " + j);
            count++;

        }
    }
}

Console.WriteLine();
Console.WriteLine("Таких чисел в массиве " + count);

