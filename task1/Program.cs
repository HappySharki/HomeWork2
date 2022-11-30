//Задача 10: Напишите программу, 
//которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

using static System.Console;
Clear();

int a = Convert.ToInt32(ReadLine());
int remnant = a / 10 % 10;
WriteLine(remnant);