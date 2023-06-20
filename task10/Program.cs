/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Input number XXX: ");
int num = int.Parse(Console.ReadLine()!);
int lognum = 0;
int secnum = 0;

if(num>100 && num<1000)
{
    lognum = num%100;
    secnum = lognum/10;
    Console.WriteLine($"{num} -> {secnum}");
} 
else
{
    Console.WriteLine("Wrong number! Input XXX. Example: 785");
}