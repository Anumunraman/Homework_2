/*
string number = "54";

if (number.Length > 2) Console.WriteLine(number[2]);
else Console.WriteLine ("в числе менее трёх сиволов");
*/

int number = 27548554; //275%10 = 5
while (number/1000 > 0)
{
    number/=10;
    Console.WriteLine(number);
}
Console.WriteLine(number%10);