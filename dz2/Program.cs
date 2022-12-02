 Console.WriteLine("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine()!);

 if(a == 1){Console.WriteLine("Рабочий день");}
 if(a == 2){Console.WriteLine("Рабочий день");}
 if(a == 3){Console.WriteLine("Рабочий день");}
 if(a == 4){Console.WriteLine("Рабочий день");}
 if(a == 5){Console.WriteLine("Рабочий день");}
 if(a == 6){Console.WriteLine("Выходной");}
 if(a == 7){Console.WriteLine("Выходной");}
 if(a > 7 || a < 1){Console.WriteLine("Несуществующее значение...");}