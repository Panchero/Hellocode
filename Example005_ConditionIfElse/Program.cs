﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же ты!");
}
else
{
   Console.WriteLine("Привет, ");
   Console.WriteLine(username); 
}