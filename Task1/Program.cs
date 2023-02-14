//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
if (firstValue > secondValue)
     Console.WriteLine("число " + firstValue + " больше числа " + secondValue);
else Console.WriteLine("число " + secondValue + " больше числа " + firstValue);checked/