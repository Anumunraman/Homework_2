/* int number = -1;
if (number == 6 || number == 7)
{
    Console.WriteLine("Это выходной день");

}
else if (number > 7 || number < 1)
{
    Console.WriteLine("Ввод неверный");
}
else Console.WriteLine("Будний день");
*/
Console.WriteLine("Введите день недели: ");
string day = Console.ReadLine();
int number = Convert.ToInt32(day);
if (number == 1)
{
    Console.WriteLine("Понедельник");
}

else if (number == 2)
{
    Console.WriteLine("Вторник");
}
else if (number == 3)
{
    Console.WriteLine("Среда");
}
else if (number == 4)
{
    Console.WriteLine("Четверг");
}
else if (number == 5)
{
    Console.WriteLine("Пятница");
}
else if (number == 6)
{
    Console.WriteLine("Суббота");
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье");
}
else Console.WriteLine("Ввод невернй");