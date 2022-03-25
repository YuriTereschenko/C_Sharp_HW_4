/* Задача 29: Напишите программу, которая задаёт массив из N(-100 100) рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
}
Console.Write("[");
for (int i = 0; i < array.Length - 1; i++)
{
    System.Console.Write(array[i] + ", ");
}
Console.Write(array[array.Length - 1] + "]");