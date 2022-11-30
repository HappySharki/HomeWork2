//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

using static System.Console;
Clear();

WriteLine("Введите число, и ниже вы увидите третью цифру от вашего числа");
int n = Convert.ToInt32(ReadLine());
int n3(int a)
        {
            int result = -1;
            if (a >= 100)
            {
                while (a > 999)
                {
                    a = a / 10;
                }
                result = a % 10;
            }
            return result;
        }
if (n3(n) == -1)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра это: {n3(n)}");