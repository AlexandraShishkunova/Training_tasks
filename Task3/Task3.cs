//На вводе одно слово, удали из него все буквы "А" Выведи это слово

Console.WriteLine("Введите одно слово: ");
string word = Console.ReadLine();

string[] words = word.Split(' ');
char[] chars = word.ToCharArray();

if (words.Length==1)
{
    chars = Array.FindAll(chars, c => c != 'A' && c != 'a');
    foreach(char i in chars)
    Console.WriteLine(i);
}
   
else
    Console.WriteLine("Необходимо ввести одно слово!");
