// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> no
// 161 -> yes
Console.WriteLine($"Введите число, и я скажу кратно ли оно 7 и 23 одновременно.Зачем? Да просто! ");
int a = Convert.ToInt32(Console.ReadLine());

int Multiple723(int num)
{
    return num % 7 == 0 && num % 23 == 0 ? 1 : 0;
}
int result = Multiple723(a);
string res = result == 1 ? "yes" : "no";
Console.Write($"{a} -> {res}");