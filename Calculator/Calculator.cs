//В программе реализован калькулятор, выполняющий простейшие арифметические операции

while (true)
{
    Console.WriteLine("Введите первое число (х1): ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите второе число (х2): ");
    double x2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Выберите операцию, которую хотите выполнить: \n1.Сложение \n2.Вычитание \n3.Умножение \n4.Деление\n5.Выход");
    int operation = Convert.ToInt32(Console.ReadLine());

    switch (operation)
    {
        case 1:
            Console.WriteLine($"x1 + x2 = {x1 + x2}");
            continue;
        case 2:
            Console.WriteLine($"x1 - x2 = {x1 - x2}");
            continue;
        case 3:
            Console.WriteLine($"x1 * x2 = {x1 * x2} ");
            continue;
        case 4:
            Console.WriteLine($"x1 / x2 = {x1 / x2}");
            continue;
        case 5:
            break;
        default:
            Console.WriteLine("Такой операции нет, попробуйте еще раз.");
            continue;
    };
        break;
};

