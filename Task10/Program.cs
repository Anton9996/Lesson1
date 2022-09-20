// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number} ");


int Digit13(int num)
{
    int firstDigt = num / 100;
    int secondDigt = num % 10;
    int number13 = firstDigt*10+secondDigt;
    return number13;
}

int result = Digit13(number);
Console.Write($"1 и 3 число, числа {number} -> {result}");