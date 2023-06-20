// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int Prompt(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

bool Weekend(int number)
{
    if(number > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if(number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("It`s not a day of the week!");
    return false;
}

int number = Prompt("Enter the number of the day of the week: "); 
if (ValidateWeekday(number))
{
    if(Weekend(number))
    {
        Console.WriteLine("-> yes");
    }
    else
    {
        Console.WriteLine("-> no");
    }
}