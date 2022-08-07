Console.Write("введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "юляша")
{
    Console.WriteLine("Ура, Юля!!!");
}
else
{
    Console.Write("Пешёл ты, ");
    Console.WriteLine(username);
}