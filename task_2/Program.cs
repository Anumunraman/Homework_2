/*
string number = "54";

if (number.Length > 2) Console.WriteLine(number[2]);
else Console.WriteLine ("в числе менее трёх сиволов");
*/

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);
while (number/1000 > 0)
{
    number/=10;
}
Console.WriteLine(number%10);