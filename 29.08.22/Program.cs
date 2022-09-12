// Напишите программу, которая на вход
// принимает число и выдает его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.Write($"Квадрат числа {num} = {square} ");

