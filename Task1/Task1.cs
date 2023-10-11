//Вводятся два символа, выводятся они наоборот. То есть, ввожу А и Б, на вывод Б А

//Два символа вводятся отдельно
Console.WriteLine("Введите первый символ: ");
string symb1 = Console.ReadLine();
Console.WriteLine("Введите второй символ: ");
char symb2 = Convert.ToChar(Console.ReadLine());
Console.WriteLine($"Вывод в обратном порядке: {symb2} {symb1}");


//Строка преобразуется в массив символов
Console.WriteLine("Введите строку из двух символов: ");
string symb = Console.ReadLine();
char[] chars = symb.ToCharArray();
if (symb.Length == 2)
{
    Console.WriteLine("Вывод: ");
    for (int i = chars.Length - 1; i >= 0; i--)
  
        Console.WriteLine(chars[i]);
    
}
else
    Console.WriteLine("Строка должна содержать только 2 символа!");


//Вводится строка из двух символов
Console.WriteLine("Введите строку из двух символов: ");
string symbols = Console.ReadLine();
if (symbols.Length == 2)
{
    string revSymbols = new string(symbols.Reverse().ToArray());
    Console.WriteLine("Вывод: "+ revSymbols);
}
else
    Console.WriteLine("Строка должна содержать только 2 символа!");