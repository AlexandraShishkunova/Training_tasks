//На вводе будут числа. Тебе нужно преобразовать все в массив и вывести массив на консоль.


Console.WriteLine("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("\nВведите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    numbers[i] = number;
}

Console.WriteLine("\nВывод: ");
foreach (int item in numbers)
{
    Console.WriteLine(item);
}



