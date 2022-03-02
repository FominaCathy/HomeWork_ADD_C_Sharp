// 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Write("введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 != num2) 
    Console.WriteLine("MAX = " + Math.Max(num1, num2));
else 
    Console.WriteLine("Они равны");