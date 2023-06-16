//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите число");
string inputstring = Console.ReadLine();
int number = Convert.ToInt32(inputstring);
if ((number % 2) == 0)
{
  Console.WriteLine($"{number} явлется чётным числом");
}
else
{
   Console.WriteLine($"{number} НЕ явлется чётным числом"); 
}