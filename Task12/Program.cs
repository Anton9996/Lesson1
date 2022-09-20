// Напишите программу, которая принимает на вход два числа и проверяет, я влеется ли одно число квадратом другого
// 5,25 -> да
// -4,16 -> да
// 8,9 -> нет
Console.WriteLine($"Данная программа сравнит 2 числа и скажет, является ли одно , квадратом второго.");
Console.WriteLine($"Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
int SquareNumber(int num1,int num2)
{
    return num1 % num2 == 0 || num2 % num1 == 0 ? 1 : 0;
}
int result = SquareNumber(a,b);
string res = result == 1 ? "yes" : "no";
Console.Write($"{a},{b} -> {res}");