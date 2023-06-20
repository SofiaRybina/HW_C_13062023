// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message)
{
    Console.Write(message); //вывели "введите число"
    string value = Console.ReadLine()!; //ввели число и считали его и записали его вэлью
    int result = Convert.ToInt32(value); //преобразовали вэлью в инт и записали в резалт
    return result;
}

int GetThirdRank(int number)
{
    while(number > 999 || number < -999)
    {
        number/=10;
    }
    return number%10;
}

bool ValidateNumber(int number)
{
    if(number < 100 && number > -100)
    {
        Console.WriteLine("No third digit");
        return false;
    }
    return true;
}

int number = Prompt("Input number: "); //положили резалт в намбер
if(ValidateNumber(number)&& number>0)
{
    Console.WriteLine(GetThirdRank(number));
}
else{
    Console.WriteLine(-GetThirdRank(number));
}