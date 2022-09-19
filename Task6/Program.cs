// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих
Console.WriteLine("Данная программа , сравнит предложеные вами числа указав на наибольшее. Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) 
    max = b;
if (c > max) 
    max = c;
else {
    Console.Write("числa равны ");
}
Console.Write($"a={a};b={b};c={c} -> max = {max} ");
