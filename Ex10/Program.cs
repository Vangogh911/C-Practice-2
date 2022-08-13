// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int MidleNumber(int num)
{
    if (99 < num && num < 1000) return (num % 100)/10;
    return -1;
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int midle = MidleNumber(number);
if (midle != -1)
{
    Console.WriteLine($"Средней цифрой в числе {number} является - {midle}");
}
else
{
    Console.WriteLine("Число не трехзначное!");
}
