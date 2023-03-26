// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
string NumOne = Console.ReadLine();
int One = Convert.ToInt32(NumOne);

Console.WriteLine("Введите второе число");
string NumTwo = Console.ReadLine();
int Two = Convert.ToInt32(NumTwo);

if (One > Two) {
    Console.WriteLine($"Большим числом является {One}, а меньшим является {Two}");
} 
else {
    Console.WriteLine($"Большим числом является {Two}, а меньшим является {One}");
}
