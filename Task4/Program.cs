// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
string NumOne = Console.ReadLine();
int One = Convert.ToInt32(NumOne);

Console.WriteLine("Введите второе число");
string NumTwo = Console.ReadLine();
int Two = Convert.ToInt32(NumTwo);

Console.WriteLine("Введите третье число");
string NumThree = Console.ReadLine();
int Three = Convert.ToInt32(NumThree);
int max= 0;

if (One > Two) {
    max = One;
    if (One > Three){
        max = One;
    }
    else {
        max = Three;
    }
} 
else {
    max = Two;
    if (Two > Three){
        max = Two;
    }
    else {
        max = Three;
    }
}
Console.WriteLine($"Большим числом является: {max}");
