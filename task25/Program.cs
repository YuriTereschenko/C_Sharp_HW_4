/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

char repeat = 'y';
double numberA = 0;
double numberB = 0;
double result = 0;
while (repeat == 'y')
{
    Console.WriteLine("Введите число А");
    numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B");
    numberB = Convert.ToInt32(Console.ReadLine());
    result = Math.Pow(numberA, numberB);
    System.Console.WriteLine($"А в степени В = {result}");
    System.Console.WriteLine("Посчитаем еще пару чисел? (y - да, n - нет)");
    repeat = char.ToLower(Convert.ToChar(Console.ReadLine()));
}