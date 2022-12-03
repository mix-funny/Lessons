Console.Clear();
Console.WriteLine("Введите любое число: ");
int num = Math.Abs(int.Parse(Console.ReadLine()!)); // Math.Abs (математическая библиотека) определяет модуль числа
int numTemp = num; // Создали временную копию числа для расчёта разрядности
int count = 0; // Счетчик разрядов

while (numTemp > 0) // Первый цикл который считает разряды
{
    numTemp /= 10;
    count ++;
}

if (count - 3 >= 0) // Условие которое опряделяет наличие как минимум 3-х цифр
{
    while ( count - 3 > 0) // Второй цикл который создает число из последних 3-х разрядов
    {
        num = num / 10;
        count --;
    }
    Console.WriteLine($"Третья цифра {num % 10}");
}
else
{
    Console.WriteLine("Третьей цифры нет...");
}