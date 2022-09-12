Console.WriteLine("Введите число недели");
int a = Convert.ToInt32(Console.ReadLine());

if (a <= 7 && a != 0 && a > 0)
{
    if (a == 1) {
        Console.WriteLine("Сегодня гребаный понедельник");
    }
    else if (a == 2) {
        Console.WriteLine("Сегодня гребаный вторник");
    }
    else if (a == 3) {
        Console.WriteLine("Сегодня уже среда");
    }
    else if (a == 4) {
        Console.WriteLine("Сегодня четверг");
    }
    else if (a == 5) {
        Console.WriteLine("Сегодня друг мой пятница");
    }
     else if (a == 6) {
        Console.WriteLine("Сегодня суббота, успей оторваться");
    }
    else if (a == 6) {
        Console.WriteLine("Сегодня воскресенье, готовь жопу к новой неделе");
    }
    }
    else {
        Console.WriteLine("Укажите число в диапазоне от 1 до 7");
    }