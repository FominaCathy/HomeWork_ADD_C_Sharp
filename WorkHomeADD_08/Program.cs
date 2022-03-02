// 8. Показать все четные числа от 1 до N
Console.Write("Введите число N: ");
int nums = Convert.ToInt32(Console.ReadLine());
int i = 2;

if (nums > 1) {
    Console.Write("Четные числа до N: ");
        while (i <= nums ){
            Console.Write(i + ", ");
            i = i + 2;
        }
} else
    Console.Write("Между 1 и " + nums + " четных чисел нет");
