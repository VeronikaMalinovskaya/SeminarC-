// Напишите программу, которая на вход принимает два числа и выдаёт максимальное.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите первое число");
double b = double.Parse(Console.ReadLine());

Console.WriteLine();

if (a > b) 
{
    Console.WriteLine(a + " Больше, чем " + b);
}
else
{
    Console.WriteLine(b + " Больше, чем " + a);
}




