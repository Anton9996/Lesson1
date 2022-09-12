// Напишите программу, которая на вход приннимает два числа и выдает, какое число больше, а какое меньше
Console.WriteLine("Данная программа , сравнит предложеные вами числа указав на наибольшее. Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) {
    Console.Write($"a={a};b={b} -> max = {a} ");
}
else if (b > a) {
  Console.Write(($"a={a};b={b} -> max = {b} "));
}
else {
    Console.Write("числa равны");
}
