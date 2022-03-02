//4. принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Ввведите первое число: ");
int nums1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите второе число: ");
int nums2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите третье число: ");
int nums3 = Convert.ToInt32(Console.ReadLine());

 
Console.Write("Максимальное число из введенных: "+Math.Max(nums1, Math.Max(nums2, nums3)));