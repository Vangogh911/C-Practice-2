// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool DayOfWeek (int num)
{
    return (num == 6)||(num == 7);
}

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (DayOfWeek(day))
{
    Console.WriteLine($"{day} день недели является выходным");
}
else
{
    Console.WriteLine($"{day} день недели НЕ является выходным");
}
