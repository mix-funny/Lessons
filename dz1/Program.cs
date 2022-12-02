Console.Clear();
Console.WriteLine("Введите нужное число: ");
int N = int.Parse(Console.ReadLine()!);

int a1 = N/10;
int a2 = a1%10;
Console.WriteLine("Второе число: " + a2);
