/*
 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

    Console.Write("Введите число A: ");
    string str = Console.ReadLine() ?? "";
    if (!int.TryParse(str, out int num1))return;

    Console.Write("Введите число B: ");
    str = Console.ReadLine() ?? "";
    if (!int.TryParse(str, out int num2))return;

    Console.WriteLine($"Число {num1} в степени {num2} равно: {Math.Pow(num1, num2)}");