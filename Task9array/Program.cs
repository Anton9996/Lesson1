// Число из отрезка [10 99] и показывает наибольшую цифру числа


int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number} ");

// int firstDigt = number / 10;
// int secondDigt = number % 10;

// if (firstDigt > secondDigt) {
// Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigt}");}
// else if (firstDigt == secondDigt) {
// Console.WriteLine($"Наибольшая цифра числа {number} -> цифры одинаковые");}
// else Console.Write($"Наибольшая цифра числа {number} -> {secondDigt}");

int MaxDigit(int num)
{
    int firstDigt = num / 10;
    int secondDigt = num % 10;
    //if (firstDigt > secondDigt) return firstDigt;   
    //return secondDigt;
    if (firstDigt == secondDigt) return -1;
    return firstDigt > secondDigt ? firstDigt : secondDigt;
}

int result = MaxDigit(number);
string res = result == -1 ? "Цифры одинаковые" : result.ToString();
Console.Write($"Наибольшая цифра числа {number} -> {res}");