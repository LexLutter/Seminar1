// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 1){
    int i = 2;
    while (i <= N){
        Console.WriteLine(i);
        i = i+2;
    }
}
else Console.WriteLine("число " + N + " меньше 2-х" );