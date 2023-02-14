// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdValue = Convert.ToInt32(Console.ReadLine());
if (firstValue > secondValue)
    if (firstValue > thirdValue) 
        Console.WriteLine("число " + firstValue + " является самым большим ");
    else Console.WriteLine("число " + thirdValue + " является самым большим ");
else
    if (secondValue > thirdValue)
        Console.WriteLine("число " + secondValue + " является самым большим ");
    else Console.WriteLine("число " + thirdValue + " является самым большим ");

