﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "regina")
{
    Console.WriteLine("I love you Regina");
}
if(username.ToLower() == "миша")
{
    Console.WriteLine("Ура это же Миша");
}
else
{
    Console.Write("Hello ");
    Console.WriteLine(username);
}