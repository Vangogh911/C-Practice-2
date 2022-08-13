// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. Решить без использования строк.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit (int num)
{
    if (num>99) return (num/100)%10;
    return -1;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int third = ThirdDigit(number);
if (third != -1)
{
    Console.WriteLine($"Третьей цифрой в {number} является - {third}");
}
else
{
    Console.WriteLine($"В {number} нет третьей цифры!");
}
