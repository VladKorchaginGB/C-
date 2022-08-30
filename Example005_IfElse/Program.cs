Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "влад")
{
    Console.WriteLine("Ура, это же Влад!!!");
}
else
{
    Console.WriteLine("Добрый день, ");
    Console.WriteLine(username);
}
